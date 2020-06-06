// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [Extension("ARM_import_memory")]
    public unsafe partial class ArmImportMemory : NativeExtension<CL>
    {
        public const string ExtensionName = "ARM_import_memory";
        [NativeApi(EntryPoint = "clImportMemoryARM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr ImportMemory([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplImportMemory(context, flags, properties, memory, size, errcode_ret);

        [NativeApi(EntryPoint = "clImportMemoryARM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
            => ImplImportMemory<T0>(context, flags, properties, memory, size, errcode_ret);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr ImportMemory([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] IntPtr* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return ImportMemory(new IntPtr(context), flags, properties, memory, new UIntPtr(size), errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr ImportMemory<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] Span<IntPtr> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return ImportMemory(new IntPtr(context), flags, properties, memory, new UIntPtr(size), errcode_ret);
        }

        public ArmImportMemory(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

