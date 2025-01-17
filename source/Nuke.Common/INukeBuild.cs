// Copyright 2020 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common.Execution;
using Nuke.Common.IO;

namespace Nuke.Common
{
    public interface INukeBuild
    {
        void ReportSummary(string caption, string text);

        IReadOnlyCollection<ExecutableTarget> InvokedTargets { get; }
        IReadOnlyCollection<ExecutableTarget> SkippedTargets { get; }
        IReadOnlyCollection<ExecutableTarget> ScheduledTargets { get; }
        IReadOnlyCollection<ExecutableTarget> RunningTargets { get; }
        IReadOnlyCollection<ExecutableTarget> AbortedTargets { get; }
        IReadOnlyCollection<ExecutableTarget> FailedTargets { get; }
        IReadOnlyCollection<ExecutableTarget> SucceededTargets { get; }
        IReadOnlyCollection<ExecutableTarget> FinishedTargets { get; }

        bool IsSuccessful { get; }
        bool IsFailing { get; }
        bool IsFinished { get; }
        int? ExitCode { get; set; }

        AbsolutePath RootDirectory { get; }
        AbsolutePath TemporaryDirectory { get; }
        AbsolutePath BuildAssemblyDirectory { get; }
        [CanBeNull] AbsolutePath BuildProjectDirectory { get; }
        [CanBeNull] AbsolutePath BuildProjectFile { get; }

        Verbosity Verbosity { get; }
        Host Host { get; }
        bool Plan { get; }
        bool Help { get; }
        bool NoLogo { get; }
        bool IsLocalBuild {get;}
        bool IsServerBuild {get;}
        LogLevel LogLevel {get;}
        bool Continue { get; }
    }
}
