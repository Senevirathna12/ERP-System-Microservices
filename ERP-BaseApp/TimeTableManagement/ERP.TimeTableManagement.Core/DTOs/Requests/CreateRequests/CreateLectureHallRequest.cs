﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.TimeTableManagement.Core.DTOs.Requests.CreateRequests
{
    public class CreateLectureHallRequest
    {
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
    }
}
