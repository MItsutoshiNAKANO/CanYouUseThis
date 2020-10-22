# C++/CLIで書かれたdllをIIS上のASP.NETプログラムから参照するには?

C++/CLIで書かれたdllをC#のASP.NETプログラムから呼び出そうとしています。
 <https://github.com/MItsutoshiNAKANO/CanYouUseThis>
IIS Express上ではdllに定義されたMessage "Can you call me?"が表示されます。

しかし、Windows 10のIISへこのプログラムを公開して、ブラウザから呼び出すと、
ブラウザ上で、下記に記したエラーメッセージが表示され、実行できません。
エラーメッセージから察するに、
バイナリーの形式が間違っていると予想しています。
しかし、ソリューションや各プロジェクトのプロパティを見ても
どこを直せば良いのか解らないでいます。

どこをどう修正すればこのプログラムは正しく動作するでしょうか?
どなたか教えていただけたらありがたいです。

## IISのerror page

'/' アプリケーションでサーバー エラーが発生しました。
ファイルまたはアセンブリ 'CallerAspDotNet'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。
説明: 現在の Web 要求を実行中に、ハンドルされていない例外が発生しました。エラーに関する詳細および例外の発生場所については、スタック トレースを参照してください。

例外の詳細: System.BadImageFormatException: ファイルまたはアセンブリ 'CallerAspDotNet'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。

ソース エラー:

現在の Web 要求の実行中にハンドルされていない例外が生成されました。障害の原因および発生場所に関する情報については、下の例外スタック トレースを使って確認できます。

アセンブリ読み込みトレース: 以下の情報は、アセンブリ 'CallerAspDotNet' を読み込めなかった原因を調べるのに役立ちます。


警告: アセンブリ バインドのログ記録がオフにされています。
アセンブリ バインドのエラー ログを有効にするには、レジストリ値 [HKLM\Software\Microsoft\Fusion!EnableLog] (DWORD) を 1 に設定してください。
注意: アセンブリ バインドのエラー ログに関連するパフォーマンス ペナルティがあります。
この機能をオフにするには、レジストリ値 [HKLM\Software\Microsoft\Fusion!EnableLog] を削除します。

スタック トレース:


[BadImageFormatException: ファイルまたはアセンブリ 'CallerAspDotNet'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。]
   System.Reflection.RuntimeAssembly._nLoad(AssemblyName fileName, String codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +0
   System.Reflection.RuntimeAssembly.InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +232
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean forIntrospection) +113
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, Boolean forIntrospection) +23
   System.Reflection.Assembly.Load(String assemblyString) +35
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +49

[ConfigurationErrorsException: ファイルまたはアセンブリ 'CallerAspDotNet'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。]
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +762
   System.Web.Configuration.CompilationSection.LoadAllAssembliesFromAppDomainBinDirectory() +259
   System.Web.Configuration.CompilationSection.LoadAssembly(AssemblyInfo ai) +167
   System.Web.Compilation.BuildManager.GetReferencedAssemblies(CompilationSection compConfig) +238
   System.Web.Compilation.BuildManager.GetPreStartInitMethodsFromReferencedAssemblies() +78
   System.Web.Compilation.BuildManager.CallPreStartInitMethods(String preStartInitListPath, Boolean& isRefAssemblyLoaded) +334
   System.Web.Compilation.BuildManager.ExecutePreAppStart() +178
   System.Web.Hosting.HostingEnvironment.Initialize(ApplicationManager appManager, IApplicationHost appHost, IConfigMapPathFactory configMapPathFactory, HostingEnvironmentParameters hostingParameters, PolicyLevel policyLevel, Exception appDomainCreationException) +746

[HttpException (0x80004005): ファイルまたはアセンブリ 'CallerAspDotNet'、またはその依存関係の 1 つが読み込めませんでした。間違ったフォーマットのプログラムを読み込もうとしました。]
   System.Web.HttpRuntime.FirstRequestInit(HttpContext context) +552
   System.Web.HttpRuntime.EnsureFirstRequestInit(HttpContext context) +122
   System.Web.HttpRuntime.ProcessRequestNotificationPrivate(IIS7WorkerRequest wr, HttpContext context) +737

バージョン情報: Microsoft .NET Framework バージョン:4.0.30319; ASP.NET バージョン:4.8.4250.0

## versions

Visual Studio 2019 ver. 16.7.6
Windows 10 Pro 2004
バージョン情報: Microsoft .NET Framework バージョン:4.0.30319;
ASP.NET バージョン:4.8.4250.0

## 私のスキルレベルについて

20年来UNIX・Linuxを中心にプログラミングを行ってきました。
ASP.NETでの開発は何年かぶりになります。
docs.microsoft.comのドキュメントは、日本語・英語を行き来しながら読めば、
意味は解ります。
