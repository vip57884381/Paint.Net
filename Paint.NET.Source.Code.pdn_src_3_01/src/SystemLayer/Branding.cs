/////////////////////////////////////////////////////////////////////////////////
// Paint.NET                                                                   //
// Copyright (C) Rick Brewster, Tom Jackson, and past contributors.            //
// Portions Copyright (C) Microsoft Corporation. All Rights Reserved.          //
// See src/Resources/Files/License.txt for full licensing and attribution      //
// details.                                                                    //
// .                                                                           //
/////////////////////////////////////////////////////////////////////////////////

namespace PaintDotNet.SystemLayer
{
    /// <summary>
    /// Provides methods that control branding aspects of Paint.NET. For instance,
    /// the URL we ping for update manifests, and the e-mail address to send
    /// feedback to.
    /// </summary>
    public static class Branding
    {
        public const string FeedbackEmail = "paint.net@hotmail.com";

        public const string WebsiteUrl = "http://www.getpaint.net";
    }
}