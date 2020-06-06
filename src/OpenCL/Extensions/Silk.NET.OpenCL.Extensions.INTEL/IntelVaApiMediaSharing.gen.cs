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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_va_api_media_sharing")]
    public unsafe partial class IntelVaApiMediaSharing : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_va_api_media_sharing";
        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret)
            => ImplCreateFromVAApimediaSurface(context, flags, surface, plane, errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromVA_APIMediaSurfaceINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] IntPtr surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
            => ImplCreateFromVAApimediaSurface(context, flags, surface, plane, errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireVA_APIMediaSurfacesINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueAcquireVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
            => ImplEnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseVA_APIMediaSurfacesINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] IntPtr command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
            => ImplEnqueueReleaseVAApimediaSurfaces(command_queue, num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
            => ImplGetDeviceIDsFromVAApimediaAdapter(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);

        [NativeApi(EntryPoint = "clGetDeviceIDsFromVA_APIMediaAdapterINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetDeviceIDsFromVAApimediaAdapter<T0>([Flow(FlowDirection.In)] IntPtr platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
            => ImplGetDeviceIDsFromVAApimediaAdapter<T0>(platform, media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] int surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromVAApimediaSurface(new IntPtr(context), flags, new IntPtr(surface), plane, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr CreateFromVAApimediaSurface([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.Out)] int surface, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateFromVAApimediaSurface(new IntPtr(context), flags, new IntPtr(surface), plane, errcode_ret);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueAcquireVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueAcquireVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] IntPtr* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] IntPtr* event_wait_list, [Flow(FlowDirection.Out)] IntPtr* @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int EnqueueReleaseVAApimediaSurfaces([Flow(FlowDirection.In)] int command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] Span<IntPtr> mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] Span<IntPtr> event_wait_list, [Flow(FlowDirection.Out)] Span<IntPtr> @event)
        {
            // IntPtrOverloader
            return EnqueueReleaseVAApimediaSurfaces(new IntPtr(command_queue), num_objects, mem_objects, num_events_in_wait_list, event_wait_list, @event);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromVAApimediaAdapter([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] void* media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] IntPtr* devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // IntPtrOverloader
            return GetDeviceIDsFromVAApimediaAdapter(new IntPtr(platform), media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetDeviceIDsFromVAApimediaAdapter<T0>([Flow(FlowDirection.In)] int platform, [Flow(FlowDirection.In)] uint media_adapter_type, [Flow(FlowDirection.Out)] Span<T0> media_adapter, [Flow(FlowDirection.In)] uint media_adapter_set, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<IntPtr> devices, [Flow(FlowDirection.Out)] Span<uint> num_devices) where T0 : unmanaged
        {
            // IntPtrOverloader
            return GetDeviceIDsFromVAApimediaAdapter(new IntPtr(platform), media_adapter_type, media_adapter, media_adapter_set, num_entries, devices, num_devices);
        }

        public IntelVaApiMediaSharing(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

