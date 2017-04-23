# oracleclientcore  
  
unofficial oracle client for .net core.  based on mono's oracle client  
  
Update on 04/23/2017 - converted solution/project to Visual Studio 2017.  added compiler defines for a platform to the oci library.  
  
OCI_WINDOWS is "oci" which is oci.dll  
OCI_LINUX is "libclntsh.so"  
OCI_MACOS is "libclntsh.dynlib". not sure about Mac OS.  
  
In OciDefines.cs, just define one of the above like:  
#define OCI_WINDOWS  
  


