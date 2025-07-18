﻿using HuayiQi.CompatCircuitCore.Arithmetic;

namespace HuayiQi.CollaborativeZkVm.ZkPrograms;
public class ZkProgramExecuteResult {
    public required IReadOnlyList<Field> PublicOutputs { get; init; }
    public required int GlobalStepCounter { get; init; }
    public required TimeSpan TotalTime { get; init; }
    public required IReadOnlyDictionary<string, TimeSpan> StepTimes { get; init; }
}
