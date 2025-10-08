using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class GuestDB: DB
    {

            #region Data Members
            private string table = "Guest";
            private string sqlLocal = "SELECT * FROM Guest";
            private Collection<Guest> guests;
            #endregion

            #region Properties
            public Collection<Guest> AllGuests => guests;
            #endregion

            #region Constructor
            public GuestDB() : base()
            {
                guests = new Collection<Guest>();
                FillDataSet(sqlLocal, table);
                AddToCollection();
            }
            #endregion

            #region Utility Methods
            public DataSet GetDataSet() => dsMain;

            private void AddToCollection()
            {
                foreach (DataRow row in dsMain.Tables[table].Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        var guest = new Guest(
                            row["FirstName"].ToString().Trim(),
                            row["LastName"].ToString().Trim(),
                            row["Email"].ToString().Trim(),
                            row["Phone"].ToString().Trim(),
                            row["Address"].ToString().Trim()
                        );

                        // Override auto-generated GuestId with DB value
                        guest.GetType().GetProperty("GuestId")
                            .SetValue(guest, row["Id"].ToString());

                        // Extract last 4 digits from full credit card number
                        string fullCard = row["CreditCardNum"].ToString().Trim();
                        if (fullCard.Length >= 4)
                            guest.UpdateCreditCard(fullCard.Substring(fullCard.Length - 4));

                        guest.GetType().GetProperty("DateRegistered")
                            .SetValue(guest, Convert.ToDateTime(row["DateRegistered"]));

                        guest.IsInGoodStanding = row["IsInGoodStanding"] != DBNull.Value && Convert.ToBoolean(row["IsInGoodStanding"]);

                        guests.Add(guest);
                    }
                }
            }

            private void FillRow(DataRow row, Guest guest)
            {
                row["Id"] = int.TryParse(guest.GuestId, out int id) ? id : new Random().Next(100000, 999999); // fallback if not numeric
                row["FirstName"] = guest.FirstName;
                row["LastName"] = guest.LastName;
                row["Email"] = guest.Email;
                row["Phone"] = guest.Phone;
                row["Address"] = guest.Address;
                row["CreditCardNum"] = guest.CreditCardLastFourDigits; // assumes full number stored elsewhere
                row["DateRegistered"] = guest.DateRegistered;
                row["IsInGoodStanding"] = guest.IsInGoodStanding;
            }
            #endregion

            #region CRUD Operations
            public void DataSetChange(Guest guest)
            {
                DataRow row = dsMain.Tables[table].NewRow();
                FillRow(row, guest);
                dsMain.Tables[table].Rows.Add(row);
            }
            #endregion

            #region SQL Command Construction
            private void BuildInsertParameters()
            {
                SqlParameter param;

                param = new SqlParameter("@Id", SqlDbType.NVarChar, 50, "Id");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.NVarChar, 50, "Phone");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CreditCardNum", SqlDbType.NVarChar, 50, "CreditCardNum");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@DateRegistered", SqlDbType.DateTime, 8, "DateRegistered");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@IsInGoodStanding", SqlDbType.Bit, 1, "IsInGoodStanding");
                daMain.InsertCommand.Parameters.Add(param);
            }

            private void CreateInsertCommand()
            {
                daMain.InsertCommand = new SqlCommand(
                    "INSERT INTO Guest (Id, FirstName, LastName, Email, Phone, Address, CreditCardNum, DateRegistered, IsInGoodStanding) " +
                    "VALUES (@Id, @FirstName, @LastName, @Email, @Phone, @Address, @CreditCardNum, @DateRegistered, @IsInGoodStanding)",
                    cnMain);
                BuildInsertParameters();
            }

            public bool UpdateDataSource(Guest guest)
            {
                CreateInsertCommand();
                return UpdateDataSource(sqlLocal, table);
            }
            #endregion
        
    }
}

