﻿namespace Keras.Optimizers
{
    /// <summary>
    ///     Adam optimizer. Default parameters follow those provided in the original paper.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adam : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Adam" /> class.
        /// </summary>
        /// <param name="lr">The lr.</param>
        /// <param name="beta_1">The beta 1.</param>
        /// <param name="beta_2">The beta 2.</param>
        /// <param name="epsilon">The epsilon.</param>
        /// <param name="decay">The decay.</param>
        /// <param name="amsgrad">
        ///     boolean. Whether to apply the AMSGrad variant of this algorithm from the paper "On the
        ///     Convergence of Adam and Beyond".
        /// </param>
        public Adam(float lr = 0.001f, float beta_1 = 0.9f, float beta_2 = 0.999f, float? epsilon = null,
            float decay = 0.0f, bool amsgrad = false)
        {
            Parameters["lr"] = lr;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;
            Parameters["amsgrad"] = amsgrad;

            PyInstance = Instance.keras.optimizers.Adam;
            Init();
        }
    }
}