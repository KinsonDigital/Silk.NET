// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_fragment_coverage_to_color")]
    public unsafe partial class NVFragmentCoverageToColor : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_coverage_to_color";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="color">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentCoverageColorNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentCoverageColor([Flow(FlowDirection.In)] uint color)
            => ImplFragmentCoverageColor(color);

        public NVFragmentCoverageToColor(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

