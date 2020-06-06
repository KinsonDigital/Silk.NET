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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_framebuffer_CMAA")]
    public unsafe partial class IntelFramebufferCmaa : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_framebuffer_CMAA";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glApplyFramebufferAttachmentCMAAINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ApplyFramebufferAttachmentCmaa()
            => ImplApplyFramebufferAttachmentCmaa();

        public IntelFramebufferCmaa(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

