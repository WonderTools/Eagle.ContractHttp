﻿using System;
using System.Collections.Generic;

namespace WonderTools.Eagle.Contract
{
    public class TestResult
    {
        public string Id { get; set; }
        public string Result { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double DurationInMs { get; set; }
        public List<string> Logs { get; set; }
    }
}