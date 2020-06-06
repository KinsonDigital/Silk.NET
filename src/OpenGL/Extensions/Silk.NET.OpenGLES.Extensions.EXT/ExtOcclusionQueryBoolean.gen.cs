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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_occlusion_query_boolean")]
    public unsafe partial class ExtOcclusionQueryBoolean : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_occlusion_query_boolean";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQuery(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids)
            => ImplDeleteQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids)
            => ImplDeleteQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQueryEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQuery([Flow(FlowDirection.In)] EXT target)
            => ImplEndQuery(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids)
            => ImplGenQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
            => ImplGenQueries(n, ids);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsQueryEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsQuery([Flow(FlowDirection.In)] uint id)
            => ImplIsQuery(id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id)
            => ImplBeginQuery(target, id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndQueryEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndQuery([Flow(FlowDirection.In)] QueryTarget target)
            => ImplEndQuery(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetQuery(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetQueryObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public ExtOcclusionQueryBoolean(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

