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

namespace Silk.NET.OpenGLES.Extensions.INTEL
{
    [Extension("INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_performance_query";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginPerfQueryINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginPerfQuery([Flow(FlowDirection.In)] uint queryHandle)
            => ImplBeginPerfQuery(queryHandle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* queryHandle)
            => ImplCreatePerfQuery(queryId, queryHandle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] Span<uint> queryHandle)
            => ImplCreatePerfQuery(queryId, queryHandle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeletePerfQueryINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeletePerfQuery([Flow(FlowDirection.In)] uint queryHandle)
            => ImplDeletePerfQuery(queryHandle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndPerfQueryINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndPerfQuery([Flow(FlowDirection.In)] uint queryHandle)
            => ImplEndPerfQuery(queryHandle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFirstPerfQueryId([Flow(FlowDirection.Out)] uint* queryId)
            => ImplGetFirstPerfQueryId(queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFirstPerfQueryId([Flow(FlowDirection.Out)] Span<uint> queryId)
            => ImplGetFirstPerfQueryId(queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="nextQueryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* nextQueryId)
            => ImplGetNextPerfQueryId(queryId, nextQueryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="nextQueryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] Span<uint> nextQueryId)
            => ImplGetNextPerfQueryId(queryId, nextQueryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="counterId">
        /// To be added.
        /// </param>
        /// <param name="counterNameLength">
        /// To be added.
        /// </param>
        /// <param name="counterName">
        /// To be added.
        /// </param>
        /// <param name="counterDescLength">
        /// To be added.
        /// </param>
        /// <param name="counterDesc">
        /// To be added.
        /// </param>
        /// <param name="counterOffset">
        /// To be added.
        /// </param>
        /// <param name="counterDataSize">
        /// To be added.
        /// </param>
        /// <param name="counterTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="counterDataTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="rawCounterMaxValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] char* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] char* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
            => ImplGetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="counterId">
        /// To be added.
        /// </param>
        /// <param name="counterNameLength">
        /// To be added.
        /// </param>
        /// <param name="counterName">
        /// To be added.
        /// </param>
        /// <param name="counterDescLength">
        /// To be added.
        /// </param>
        /// <param name="counterDesc">
        /// To be added.
        /// </param>
        /// <param name="counterOffset">
        /// To be added.
        /// </param>
        /// <param name="counterDataSize">
        /// To be added.
        /// </param>
        /// <param name="counterTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="counterDataTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="rawCounterMaxValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] Span<char> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] Span<char> counterDesc, [Flow(FlowDirection.Out)] Span<uint> counterOffset, [Flow(FlowDirection.Out)] Span<uint> counterDataSize, [Flow(FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
            => ImplGetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="bytesWritten">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] uint* bytesWritten)
            => ImplGetPerfQueryData(queryHandle, flags, dataSize, data, bytesWritten);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="bytesWritten">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfQueryData<T0>([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] Span<T0> data, [Flow(FlowDirection.Out)] Span<uint> bytesWritten) where T0 : unmanaged
            => ImplGetPerfQueryData<T0>(queryHandle, flags, dataSize, data, bytesWritten);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfQueryIdByName([Flow(FlowDirection.Out)] char* queryName, [Flow(FlowDirection.Out)] uint* queryId)
            => ImplGetPerfQueryIdByName(queryName, queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfQueryIdByName([Flow(FlowDirection.Out)] Span<char> queryName, [Flow(FlowDirection.Out)] Span<uint> queryId)
            => ImplGetPerfQueryIdByName(queryName, queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryNameLength">
        /// To be added.
        /// </param>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="noCounters">
        /// To be added.
        /// </param>
        /// <param name="noInstances">
        /// To be added.
        /// </param>
        /// <param name="capsMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] char* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
            => ImplGetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryNameLength">
        /// To be added.
        /// </param>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="noCounters">
        /// To be added.
        /// </param>
        /// <param name="noInstances">
        /// To be added.
        /// </param>
        /// <param name="capsMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] Span<char> queryName, [Flow(FlowDirection.Out)] Span<uint> dataSize, [Flow(FlowDirection.Out)] Span<uint> noCounters, [Flow(FlowDirection.Out)] Span<uint> noInstances, [Flow(FlowDirection.Out)] Span<uint> capsMask)
            => ImplGetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="counterId">
        /// To be added.
        /// </param>
        /// <param name="counterNameLength">
        /// To be added.
        /// </param>
        /// <param name="counterName">
        /// To be added.
        /// </param>
        /// <param name="counterDescLength">
        /// To be added.
        /// </param>
        /// <param name="counterDesc">
        /// To be added.
        /// </param>
        /// <param name="counterOffset">
        /// To be added.
        /// </param>
        /// <param name="counterDataSize">
        /// To be added.
        /// </param>
        /// <param name="counterTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="counterDataTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="rawCounterMaxValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
            => ImplGetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="counterId">
        /// To be added.
        /// </param>
        /// <param name="counterNameLength">
        /// To be added.
        /// </param>
        /// <param name="counterName">
        /// To be added.
        /// </param>
        /// <param name="counterDescLength">
        /// To be added.
        /// </param>
        /// <param name="counterDesc">
        /// To be added.
        /// </param>
        /// <param name="counterOffset">
        /// To be added.
        /// </param>
        /// <param name="counterDataSize">
        /// To be added.
        /// </param>
        /// <param name="counterTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="counterDataTypeEnum">
        /// To be added.
        /// </param>
        /// <param name="rawCounterMaxValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] Span<uint> counterOffset, [Flow(FlowDirection.Out)] Span<uint> counterDataSize, [Flow(FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(FlowDirection.Out)] Span<ulong> rawCounterMaxValue)
            => ImplGetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* queryId)
            => ImplGetPerfQueryIdByName(queryName, queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] Span<uint> queryId)
            => ImplGetPerfQueryIdByName(queryName, queryId);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryNameLength">
        /// To be added.
        /// </param>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="noCounters">
        /// To be added.
        /// </param>
        /// <param name="noInstances">
        /// To be added.
        /// </param>
        /// <param name="capsMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
            => ImplGetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryNameLength">
        /// To be added.
        /// </param>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="dataSize">
        /// To be added.
        /// </param>
        /// <param name="noCounters">
        /// To be added.
        /// </param>
        /// <param name="noInstances">
        /// To be added.
        /// </param>
        /// <param name="capsMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] Span<uint> dataSize, [Flow(FlowDirection.Out)] Span<uint> noCounters, [Flow(FlowDirection.Out)] Span<uint> noInstances, [Flow(FlowDirection.Out)] Span<uint> capsMask)
            => ImplGetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, capsMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreatePerfQuery()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreatePerfQuery(queryId, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetFirstPerfQueryId()
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetFirstPerfQueryId(&ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="nextQueryId">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetNextPerfQueryId()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetNextPerfQueryId(queryId, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] char* queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

