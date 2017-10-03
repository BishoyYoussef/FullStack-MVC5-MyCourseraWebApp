﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCourseraWebApp.Models;

namespace MyCourseraWebApp.DTOs
{
    public class CourseCancelledUserNotificationDto
    {
        public CourseCancelledNotificationDto Notification { get; set; }
        public bool IsDismissed { get; set; }
        public bool IsSeen { get; set; }
    }
}