﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using CUDAFingerprinting.Common;
using CUDAFingerprinting.ImageEnhancement.ContextualGabor;

namespace CUDAFingerprinting.ImageEnhancement.ContextualGabor.Tests
{
    [TestClass]
    public class GradientTest
    {
        [TestMethod]
        public void GradientsTest()
        {
            var img = ImageHelper.LoadImageAsInt(TestResources.Bikesgray);
            Normalizer.Normalize(100, 500, img);
            var grad = GradientHelper.GenerateGradient(img);
            var path = Path.GetTempPath() + "grad.png";
            ImageHelper.SaveIntArray(grad, path);
            Process.Start(path);
        }
    }
}
