using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D5 RID: 725
	public static class FinishReasonConverter
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x0004D8FC File Offset: 0x0004C8FC
		static FinishReasonConverter()
		{
			FinishReasonConverter.typeMap["Unknown"] = FinishReason.Unknown;
			FinishReasonConverter.typeMap["Completed"] = FinishReason.Completed;
			FinishReasonConverter.typeMap["Succeeded"] = FinishReason.Succeeded;
			FinishReasonConverter.typeMap["DidNotFinish"] = FinishReason.DidNotFinish;
			FinishReasonConverter.typeMap["CrossedFinish"] = FinishReason.CrossedFinish;
			FinishReasonConverter.typeMap["KnockedOut"] = FinishReason.KnockedOut;
			FinishReasonConverter.typeMap["Totalled"] = FinishReason.Totalled;
			FinishReasonConverter.typeMap["EngineBlown"] = FinishReason.EngineBlown;
			FinishReasonConverter.typeMap["Busted"] = FinishReason.Busted;
			FinishReasonConverter.typeMap["Evaded"] = FinishReason.Evaded;
			FinishReasonConverter.typeMap["ChallengeCompleted"] = FinishReason.ChallengeCompleted;
			FinishReasonConverter.typeMap["Disconnected"] = FinishReason.Disconnected;
			FinishReasonConverter.typeMap["FalseStart"] = FinishReason.FalseStart;
			FinishReasonConverter.typeMap["Aborted"] = FinishReason.Aborted;
			FinishReasonConverter.typeMap["TimedOut"] = FinishReason.TimedOut;
			FinishReasonConverter.typeMap["TimeLimitExpired"] = FinishReason.TimeLimitExpired;
			FinishReasonConverter.typeMap["PauseDetected"] = FinishReason.PauseDetected;
			FinishReasonConverter.typeMap["SpeedHacking"] = FinishReason.SpeedHacking;
			FinishReasonConverter.typeMap["CodePatchDetected"] = FinishReason.CodePatchDetected;
			FinishReasonConverter.typeMap["BadVerifierResponse"] = FinishReason.BadVerifierResponse;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0004DA8B File Offset: 0x0004CA8B
		public static bool Parse(string str, out FinishReason value)
		{
			if (FinishReasonConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = FinishReason.Unknown;
			return false;
		}

		// Token: 0x040007FF RID: 2047
		private static Dictionary<string, FinishReason> typeMap = new Dictionary<string, FinishReason>();
	}
}
