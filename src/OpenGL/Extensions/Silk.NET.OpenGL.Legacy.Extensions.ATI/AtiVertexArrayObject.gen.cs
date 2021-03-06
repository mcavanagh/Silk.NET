// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_array_object")]
    public abstract unsafe partial class AtiVertexArrayObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public abstract void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFreeObjectBufferATI")]
        public abstract void FreeObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public abstract unsafe void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public abstract void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public abstract unsafe void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public abstract void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public abstract unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public abstract void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public abstract unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public abstract void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public abstract unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public abstract void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public abstract unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public abstract void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsObjectBufferATI")]
        public abstract bool IsObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public abstract unsafe uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public abstract uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public abstract unsafe void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI preserve);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public abstract void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        public abstract void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public abstract void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public abstract unsafe void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public abstract void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public abstract unsafe void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public abstract void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public abstract unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public abstract void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public abstract unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public abstract void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public abstract unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public abstract void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public abstract unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public abstract void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public abstract unsafe uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public abstract uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public abstract unsafe void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public abstract void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        public abstract void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        public AtiVertexArrayObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

