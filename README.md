# C++/CLI�ŏ����ꂽdll��IIS���ASP.NET�v���O��������Q�Ƃ���ɂ�?

C++/CLI�ŏ����ꂽdll��C#��ASP.NET�v���O��������Ăяo�����Ƃ��Ă��܂��B
 <https://github.com/MItsutoshiNAKANO/CanYouUseThis>
IIS Express��ł�dll�ɒ�`���ꂽMessage "Can you call me?"���\������܂��B

�������AWindows 10��IIS�ւ��̃v���O���������J���āA�u���E�U����Ăяo���ƁA
�u���E�U��ŁA���L�ɋL�����G���[���b�Z�[�W���\������A���s�ł��܂���B
�G���[���b�Z�[�W����@����ɁA
�o�C�i���[�̌`�����Ԉ���Ă���Ɨ\�z���Ă��܂��B
�������A�\�����[�V������e�v���W�F�N�g�̃v���p�e�B�����Ă�
�ǂ��𒼂��Ηǂ��̂�����Ȃ��ł��܂��B

�ǂ����ǂ��C������΂��̃v���O�����͐��������삷��ł��傤��?
�ǂȂ��������Ă����������炠�肪�����ł��B

## IIS��error page

'/' �A�v���P�[�V�����ŃT�[�o�[ �G���[���������܂����B
�t�@�C���܂��̓A�Z���u�� 'CallerAspDotNet'�A�܂��͂��̈ˑ��֌W�� 1 ���ǂݍ��߂܂���ł����B�Ԉ�����t�H�[�}�b�g�̃v���O������ǂݍ������Ƃ��܂����B
����: ���݂� Web �v�������s���ɁA�n���h������Ă��Ȃ���O���������܂����B�G���[�Ɋւ���ڍׂ���ї�O�̔����ꏊ�ɂ��ẮA�X�^�b�N �g���[�X���Q�Ƃ��Ă��������B

��O�̏ڍ�: System.BadImageFormatException: �t�@�C���܂��̓A�Z���u�� 'CallerAspDotNet'�A�܂��͂��̈ˑ��֌W�� 1 ���ǂݍ��߂܂���ł����B�Ԉ�����t�H�[�}�b�g�̃v���O������ǂݍ������Ƃ��܂����B

�\�[�X �G���[:

���݂� Web �v���̎��s���Ƀn���h������Ă��Ȃ���O����������܂����B��Q�̌�������є����ꏊ�Ɋւ�����ɂ��ẮA���̗�O�X�^�b�N �g���[�X���g���Ċm�F�ł��܂��B

�A�Z���u���ǂݍ��݃g���[�X: �ȉ��̏��́A�A�Z���u�� 'CallerAspDotNet' ��ǂݍ��߂Ȃ����������𒲂ׂ�̂ɖ𗧂��܂��B


�x��: �A�Z���u�� �o�C���h�̃��O�L�^���I�t�ɂ���Ă��܂��B
�A�Z���u�� �o�C���h�̃G���[ ���O��L���ɂ���ɂ́A���W�X�g���l [HKLM\Software\Microsoft\Fusion!EnableLog] (DWORD) �� 1 �ɐݒ肵�Ă��������B
����: �A�Z���u�� �o�C���h�̃G���[ ���O�Ɋ֘A����p�t�H�[�}���X �y�i���e�B������܂��B
���̋@�\���I�t�ɂ���ɂ́A���W�X�g���l [HKLM\Software\Microsoft\Fusion!EnableLog] ���폜���܂��B

�X�^�b�N �g���[�X:


[BadImageFormatException: �t�@�C���܂��̓A�Z���u�� 'CallerAspDotNet'�A�܂��͂��̈ˑ��֌W�� 1 ���ǂݍ��߂܂���ł����B�Ԉ�����t�H�[�}�b�g�̃v���O������ǂݍ������Ƃ��܂����B]
   System.Reflection.RuntimeAssembly._nLoad(AssemblyName fileName, String codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +0
   System.Reflection.RuntimeAssembly.InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +232
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean forIntrospection) +113
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, Boolean forIntrospection) +23
   System.Reflection.Assembly.Load(String assemblyString) +35
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +49

[ConfigurationErrorsException: �t�@�C���܂��̓A�Z���u�� 'CallerAspDotNet'�A�܂��͂��̈ˑ��֌W�� 1 ���ǂݍ��߂܂���ł����B�Ԉ�����t�H�[�}�b�g�̃v���O������ǂݍ������Ƃ��܂����B]
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +762
   System.Web.Configuration.CompilationSection.LoadAllAssembliesFromAppDomainBinDirectory() +259
   System.Web.Configuration.CompilationSection.LoadAssembly(AssemblyInfo ai) +167
   System.Web.Compilation.BuildManager.GetReferencedAssemblies(CompilationSection compConfig) +238
   System.Web.Compilation.BuildManager.GetPreStartInitMethodsFromReferencedAssemblies() +78
   System.Web.Compilation.BuildManager.CallPreStartInitMethods(String preStartInitListPath, Boolean& isRefAssemblyLoaded) +334
   System.Web.Compilation.BuildManager.ExecutePreAppStart() +178
   System.Web.Hosting.HostingEnvironment.Initialize(ApplicationManager appManager, IApplicationHost appHost, IConfigMapPathFactory configMapPathFactory, HostingEnvironmentParameters hostingParameters, PolicyLevel policyLevel, Exception appDomainCreationException) +746

[HttpException (0x80004005): �t�@�C���܂��̓A�Z���u�� 'CallerAspDotNet'�A�܂��͂��̈ˑ��֌W�� 1 ���ǂݍ��߂܂���ł����B�Ԉ�����t�H�[�}�b�g�̃v���O������ǂݍ������Ƃ��܂����B]
   System.Web.HttpRuntime.FirstRequestInit(HttpContext context) +552
   System.Web.HttpRuntime.EnsureFirstRequestInit(HttpContext context) +122
   System.Web.HttpRuntime.ProcessRequestNotificationPrivate(IIS7WorkerRequest wr, HttpContext context) +737

�o�[�W�������: Microsoft .NET Framework �o�[�W����:4.0.30319; ASP.NET �o�[�W����:4.8.4250.0

## versions

Visual Studio 2019 ver. 16.7.6
Windows 10 Pro 2004
�o�[�W�������: Microsoft .NET Framework �o�[�W����:4.0.30319;
ASP.NET �o�[�W����:4.8.4250.0

## ���̃X�L�����x���ɂ���

20�N��UNIX�ELinux�𒆐S�Ƀv���O���~���O���s���Ă��܂����B
ASP.NET�ł̊J���͉��N���Ԃ�ɂȂ�܂��B
docs.microsoft.com�̃h�L�������g�́A���{��E�p����s�������Ȃ���ǂ߂΁A
�Ӗ��͉���܂��B
