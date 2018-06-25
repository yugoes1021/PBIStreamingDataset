# PBIStreamingDataset
This is a C# sample for sending your data into Streaming Dataset of Microsoft Power BI.
これは Microsoft Power BI の ストリーミングデータセットにデータを POST する C# のサンプルプログラムです。
# Setup (日本語は下です)
1. Download this project.

2. Open Visual Studio 2017.

3. Open a file "PBIRealtimeStreaming.cs", and in the following code, input a Power BI REST API URL of your Streaming Dataset.

    string realTimePushURL = "This is a Power BI REST API URL of your Streaming Dataset";
  
4. Open a file "Program.cs", and in the following code, input your category name as you like.(anything OK, example : Test-20180625)

    var category = "Input your category name";

5. Build your application and exeute debug. So the application sends data into your Streaming Dataset of Power BI Service.  

ここから日本語。

1. このプロジェクトをダウンロード
2. Visual Studio 2017 で開く
3. "PBIRealtimeStreaming.cs" を開き, ソースコードの下記の部分に Streaming Dataset の URL を入力する

    string realTimePushURL = "This is a Power BI REST API URL of your Streaming Dataset";
  
4. "Program.cs" を開いて、ソースコードの下記の部分に、何でもよいのでカテゴリ名を入力する(例： Test-20180625 など)

    var category = "Input your category name";

5. ビルドして、デバッグ実行すると、Power BI Service のストリーミングデータセットにデータが送られる
