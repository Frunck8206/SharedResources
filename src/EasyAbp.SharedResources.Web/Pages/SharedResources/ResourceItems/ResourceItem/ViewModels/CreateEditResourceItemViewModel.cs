﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.SharedResources.Web.Pages.SharedResources.ResourceItems.ResourceItem.ViewModels
{
    public class CreateEditResourceItemViewModel
    {
        [HiddenInput]
        [Display(Name = "Resource")]
        public Guid ResourceId { get; set; }

        [Display(Name = "ResourceItemName")]
        public string Name { get; set; }

        [Display(Name = "ResourceItemDescription")]
        public string Description { get; set; }

        public CreateEditResourceItemContentViewModel ResourceItemContent { get; set; }

        [Display(Name = "ResourceItemIsPublished")]
        public bool IsPublished { get; set; }

        [Display(Name = "ResourceItemIsPublic")]
        public bool IsPublic { get; set; }
    }
}