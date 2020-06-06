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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_sample_shading")]
    public unsafe partial class OesSampleShading : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_sample_shading";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinSampleShadingOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MinSampleShading([Flow(FlowDirection.In)] float value)
            => ImplMinSampleShading(value);

        public OesSampleShading(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

