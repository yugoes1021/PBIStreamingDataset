# PBIStreamingDataset
This is a C# sample for sending your data into Streaming Dataset of Microsoft Power BI.
# Setup
1. Download this project.
2. Open Visual Studio 2017.
3. Open a file "PBIRealtimeStreaming.cs", and in the following code, input a Power BI REST API URL of your Streaming Dataset.
'// Power BI REST API URL of your Streaming Dataset  
'string realTimePushURL = "<This is a Power BI REST API URL of your Streaming Dataset>";
4. Open a file "Program.cs", and in the following code, input your category name as you like.(anything OK)  
'static void Main(string[] args)  
'{  
'var category = "<Input your category name>";  
5. Build your application. So the application sends data into your Streaming Dataset of Power BI Service.  
