using Keras.Helper;
using Numpy;

namespace Keras.Datasets
{
    /// <summary>
    ///     Dataset of 50,000 32x32 color training images, labeled over 100 categories, and 10,000 test images.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Cifar100 : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <param name="label_mode">The label mode.</param>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData(string label_mode = "fine")
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.cifar10.load_data(label_mode: label_mode));
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}