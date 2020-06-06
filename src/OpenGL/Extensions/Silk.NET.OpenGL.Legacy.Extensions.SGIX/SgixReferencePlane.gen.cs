// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_reference_plane")]
    public unsafe partial class SgixReferencePlane : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_reference_plane";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] double* equation)
            => ImplReferencePlane(equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReferencePlaneSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReferencePlane([Count(Count = 4), Flow(FlowDirection.In)] Span<double> equation)
            => ImplReferencePlane(equation);

        public SgixReferencePlane(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

