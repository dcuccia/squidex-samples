// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

namespace Sample.Blog.Models
{
    public sealed class AppOptions
    {
        public string ClientId { get; set; } = "sample-blog:blog";

        public string ClientSecret { get; set; } = "ZxmQGgouOUmyVU4fh38QOCqKja3IH1vPu1dUx40KDec=";

        public string AppName { get; set; } = "sample-blog";

        public string Url { get; set; } = "https://cloud.squidex.io";
    }
}
