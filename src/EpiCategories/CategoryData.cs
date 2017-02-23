﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Routing;

namespace Geta.EpiCategories
{
    public class CategoryData : StandardContentBase, IRoutable
    {
        [UIHint(UIHint.PreviewableText)]
        [ScaffoldColumn(false)]
        [CultureSpecific]
        public virtual string URLSegment { get; set; }

        [Display(Order = 20)]
        [UIHint(UIHint.LongString)]
        [CultureSpecific]
        public virtual string Description { get; set; }

        [Display(Order = 30)]
        [CultureSpecific]
        public virtual bool IsSelectable { get; set; }

        string IRoutable.RouteSegment
        {
            get { return URLSegment; }
            set { URLSegment = value; }
        }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            IsSelectable = true;
        }
    }
}