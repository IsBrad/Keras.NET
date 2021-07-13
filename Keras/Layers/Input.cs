﻿using Numpy;

namespace Keras.Layers
{
    /// <summary>
    ///     Input() is used to instantiate a Keras tensor.   A Keras tensor is a tensor object from the underlying
    ///     backend(Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model
    ///     just by knowing the inputs and outputs of the model.
    ///     For instance, if a, b and c are Keras tensors, it becomes possible to do: model = Model(input =[a, b], output = c)
    ///     The added Keras attributes are: _keras_shape: Integer shape tuple propagated via Keras-side shape
    ///     inference._keras_history: Last layer applied to the tensor. the entire layer graph is retrievable from that layer,
    ///     recursively.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Input : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Input" /> class.
        /// </summary>
        /// <param name="shape">
        ///     A shape tuple (integer), not including the batch size. For instance, shape=(32,) indicates that the
        ///     expected input will be batches of 32-dimensional vectors.
        /// </param>
        /// <param name="batch_shape">
        ///     A shape tuple (integer), including the batch size. For instance, batch_shape=(10, 32)
        ///     indicates that the expected input will be batches of 10 32-dimensional vectors.  batch_shape=(None, 32) indicates
        ///     batches of an arbitrary number of 32-dimensional vectors.
        /// </param>
        /// <param name="name">
        ///     An optional name string for the layer. Should be unique in a model (do not reuse the same name
        ///     twice). It will be autogenerated if it isn't provided.
        /// </param>
        /// <param name="dtype">The data type expected by the input, as a string (float32, float64, int32...)</param>
        /// <param name="sparse"> A boolean specifying whether the placeholder to be created is sparse.</param>
        /// <param name="tensor">
        ///     Optional existing tensor to wrap into the Input layer. If set, the layer will not create a
        ///     placeholder tensor.
        /// </param>
        public Input(Shape shape, Shape batch_shape = null, string name = "", string dtype = "float32",
            bool sparse = false, NDarray tensor = null)
        {
            this["shape"] = shape;
            this["batch_shape"] = batch_shape;
            this["name"] = name;
            this["dtype"] = dtype;
            this["sparse"] = sparse;
            this["tensor"] = tensor;

            PyInstance = Instance.keras.layers.Input;
            Init();
        }
    }
}