using Java.Lang;

namespace Crehmann.Samples.Monodroidjarexample
{
    public abstract partial class TipCalculationServiceBase
    {
        #region ITipCalculationService Members

        Object ITipCalculationService.CalculateTip(TipRequest p0)
        {
            return CalculateTip(p0);
        }

        #endregion
    }
}