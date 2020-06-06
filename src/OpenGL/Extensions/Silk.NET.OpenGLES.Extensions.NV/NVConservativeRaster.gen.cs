// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_conservative_raster")]
    public unsafe partial class NVConservativeRaster : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xbits">
        /// To be added.
        /// </param>
        /// <param name="ybits">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSubpixelPrecisionBiasNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SubpixelPrecisionBias([Flow(FlowDirection.In)] uint xbits, [Flow(FlowDirection.In)] uint ybits)
            => ImplSubpixelPrecisionBias(xbits, ybits);

        public NVConservativeRaster(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

