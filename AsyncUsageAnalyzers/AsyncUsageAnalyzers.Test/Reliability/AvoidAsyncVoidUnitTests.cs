﻿namespace AsyncUsageAnalyzers.Test.Reliability
{
    using System.Threading;
    using System.Threading.Tasks;
    using AsyncUsageAnalyzers.Reliability;
    using Microsoft.CodeAnalysis.Diagnostics;
    using TestHelper;
    using Xunit;

    public class AvoidAsyncVoidUnitTests : DiagnosticVerifier
    {
        [Fact]
        public async Task TestAsyncReturnVoidAsync()
        {
            string testCode = @"
class ClassName
{
    async void MethodNameAsync() { }
}
";

            DiagnosticResult expected = CSharpDiagnostic().WithArguments("MethodNameAsync").WithLocation(4, 16);
            await VerifyCSharpDiagnosticAsync(testCode, expected, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TestAsyncEventHandlerReturnVoidAsync()
        {
            string testCode = @"
using System;
class ClassName
{
    ClassName()
    {
        AppDomain.CurrentDomain.DomainUnload += MethodNameAsync;
    }

    async void MethodNameAsync(object sender, EventArgs e) { }
}
";

            // This analyzer does not currently handle this case differently from any other method
            DiagnosticResult expected = CSharpDiagnostic().WithArguments("MethodNameAsync").WithLocation(10, 16);
            await VerifyCSharpDiagnosticAsync(testCode, expected, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TestAsyncReturnTaskAsync()
        {
            string testCode = @"
using System.Threading.Tasks;
class ClassName
{
    async Task MethodNameAsync() { }
}
";

            await VerifyCSharpDiagnosticAsync(testCode, EmptyDiagnosticResults, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TestAsyncReturnGenericTaskAsync()
        {
            string testCode = @"
using System.Threading.Tasks;
class ClassName
{
    async Task<int> MethodNameAsync() { return 3; }
}
";

            await VerifyCSharpDiagnosticAsync(testCode, EmptyDiagnosticResults, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TestReturnTaskAsync()
        {
            string testCode = @"
using System.Threading.Tasks;
class ClassName
{
    Task MethodNameAsync() { return Task.FromResult(3); }
}
";

            await VerifyCSharpDiagnosticAsync(testCode, EmptyDiagnosticResults, CancellationToken.None).ConfigureAwait(false);
        }

        [Fact]
        public async Task TestReturnGenericTaskAsync()
        {
            string testCode = @"
using System.Threading.Tasks;
class ClassName
{
    Task<int> MethodNameAsync() { return Task.FromResult(3); }
}
";

            await VerifyCSharpDiagnosticAsync(testCode, EmptyDiagnosticResults, CancellationToken.None).ConfigureAwait(false);
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new AvoidAsyncVoidAnalyzer();
        }
    }
}
