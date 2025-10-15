using PdfSharp.Fonts;

using System;
using System.Collections.Generic;
using System.IO;



public class ResourceFontResolver : IFontResolver
{
    private readonly Dictionary<string, byte[]> fonts = new Dictionary<string, byte[]>();

    public ResourceFontResolver()
    {
        // Add your embedded font
        fonts["CMU Bright Roman#"] = Phumla_Kamnandi_GRP_12.Properties.Resources.cmunbmr; // the # can stay
    }

    public byte[] GetFont(string faceName)
    {
        if (fonts.TryGetValue(faceName, out var data))
            return data;

        throw new InvalidOperationException($"Font {faceName} not found.");
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        // Only one font, ignore style for simplicity
        return new FontResolverInfo("CMU Bright Roman#");
    }
}
