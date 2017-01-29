#  AbsoluteLayoutLab

## XAML 版面配置 AbsoluteLayout 練習

AbsoluteLayout 讓您可以使用絕對座標的方式，配製容器內的控制項所要顯示的位置；這個專案，將會提供您練習使用 XAML AbsoluteLayout 這個版面配置的用法

https://github.com/vulcanlee/XF-Course/tree/master/AbsoluteLayoutLab

# AndroidLab

## 如何使用 Xamarin.Android 開發專案

這個專案讓您練習如何使用 Xamarin.Android工具，透過 原生 Android  API，建立一個原生 Android 應用程式

https://github.com/vulcanlee/XF-Course/tree/master/AndroidLab

# ContentPageLab

## 練習 Xamarin.Forms 原生提供的頁面導航功能(會發生錯誤的版本)

這個專案將會練習 Xamarin.Forms 原生提供的頁面導航功能，但是不透過導航頁面來操作所遇到的問題；在開發上，您可能需要使用 Code Behind 來撰寫頁面商業邏輯。

https://github.com/vulcanlee/XF-Course/tree/master/ContentPageLab

# ContentPagePrism

## 練習在 Prism 中，使用導航頁面的操作(無 NavigationPage)

練習在 Prism 中，使用導航頁面的操作；這個應用程式的第一個頁面使用 NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms"); 方式進入，可以操作與測試看，與一般應用程式有何不同，為何不會閃退(與傳統 Xamarin.Forms Code Behind 的做法。另外，這個控制項可以控制頁面上的按鈕，是否可以正常使用，這是透過了 ICommand 內所提供的功能。

https://github.com/vulcanlee/XF-Course/tree/master/ContentPagePrism

# DataBinding

## XAML 資料綁定 Data Binding 的方法與技巧

在這個練習專案中，將會學習各種資料綁定 Data Binding 的方法與技巧，以及如何建立一個 ViewModel 與建立各個所需要的屬性 Property 或集合屬性(Collection Property)，以便在 View 中可以使用資料繫結方式進行綁定。另外，也學習如何使用 Prism 的INavigationAware來進行 ViewModel 資料初始化等相關工作。

使用建構式與OnNavigatedTo來建立這個 ViewModel 的資料初始化工作，有何不同，請試著比較說明看看

https://github.com/vulcanlee/XF-Course/tree/master/DataBinding

# DeepLink

## 如何透過 Prism 提供的 INavigationService 操作頁面導航功能

在這個練習專案，我們將來練習如何透過 Prism 提供的 INavigationService 介面物件，進行各種頁面導航的操作。其中，包含了相對頁面導航的方法、深度導航、與自訂深度導航。

https://github.com/vulcanlee/XF-Course/tree/master/DeepLink

# DrawerPresent

## 練習導航抽屜頁面的開發設計方式

在這個專案中，將會練習導航抽屜頁面的開發設計方式。這包括了，如何資料繫結導航工具列頁面名稱、手動推出導航抽屜、導航頁面的設計方式、取得導航抽屜與子頁面的設計尺寸、Prism 事件聚合器用法。

https://github.com/vulcanlee/XF-Course/tree/master/DrawerPresent

# DynaDrawer

## 這個練習將會學習如何設計與使用 MasterDetailPage

在這個導航抽屜面板中，將會提供動態可收合的功能表，因此，透過這個練習，您將可以設計導航面板，使其具有更多樣性的效果；MasterDetailPage的導航面板，將是由 Master 這個屬性來呈現，這是一個使用 ContentPage 來製作出來的面板

https://github.com/vulcanlee/XF-Course/tree/master/DynaDrawer

# EntryLab

## 這個練習專案，將會學習 Entry 這個控制項的各種不同用法

這包括了使用提示浮水印、指定使用軟體鍵盤格式、預設輸入文字、設定提示浮水印文字顏色、字體大小與格式

https://github.com/vulcanlee/XF-Course/tree/master/EntryLab

# iOSLab

## Xamarin.iOS 原生專案開發練習

這個專案，將會使用原生 iOS 開發套件與原生 iOS API開發出一個原生 iOS App

https://github.com/vulcanlee/XF-Course/tree/master/iOSLab

# MapsLab

## 練習如何在 Xamarin.Forms 顯示地圖

要練習這個專案，您的模擬器必須要安裝 Google Play Service，否則，您就需要在您的實體手機上來進行開發與測試，看看執行結果。

https://github.com/vulcanlee/XF-Course/tree/master/MapsLab

# MasterDetailPageLab

## 使用 Xamarin.Forms 的基本方法，建立一個具有導航抽屜功能的應用程式

在這裡，您需要指定 MasterDetailPage.Master / MasterDetailPage.Detail 這兩個屬性，進行設定導航抽屜與子頁面的內容

https://github.com/vulcanlee/XF-Course/tree/master/MasterDetailPageLab

# MasterDetailPage1Lab

## 使用 Xamarin.Forms 建立一個導航抽屜頁面應用程式，不過，沒有使用 NavigationPage

您可以嘗試與 `使用 Xamarin.Forms 的基本方法，建立一個具有導航抽屜功能的應用程式` 這個專案來做比較

https://github.com/vulcanlee/XF-Course/tree/master/MasterDetailPage1Lab

# MasterDetailPagePrism

## 使用 Prism 開發框架，建立具有導航抽屜功能的頁面

這個練習專案，將會使用 Prism 開發框架來設計，所以，在MasterDetailPage，僅需要定義導航抽屜面板，而 Detail 屬性部分，則會由 Prism 的導航 URI 來提供

https://github.com/vulcanlee/XF-Course/tree/master/MasterDetailPagePrism

# MDVideoLab

## 導航抽屜頁面與絕對導航與相對導航

這個範例中，將會展示如何在導航抽屜面板中，切換到其他的工作頁面，不過，在此，使用的是絕對導航方式，在這個方式中，將會清除導航堆疊。您也可以使用相對導航方是，看看這兩種導航操作，有何不同

同樣的導航指令，為何從導航抽屜進行導航的沒有導航工具列，而從子頁面導航的頁面，卻有導航工具列，您知道為什麼?

https://github.com/vulcanlee/XF-Course/tree/master/MDVideoLab

# NavigationPageLab

## 練習 Xamarin.Forms 的頁面導航切換

這個練習專案內有兩個按鈕，第一個按鈕於切換頁面之後，就無法再回到原先頁面；而第二個按鈕，將可以切換到第二個頁面，也可以使用工具列或者硬體回上一頁按鈕，回到上一頁

https://github.com/vulcanlee/XF-Course/tree/master/NavigationPageLab

# NavigationPagePrism

## 如何客製化導航工具列

在這個練習專案中，您將會學習如何客製化導航工具列；我們將在 NewPage 頁面中，使用附加屬性表示方式， NavigationPage.HasBackButton="False" 設定這個頁面的導航工具列沒有回上頁按鈕圖片

https://github.com/vulcanlee/XF-Course/tree/master/NavigationPagePrism

# PrismDS

## 如何實作出相依性服務注入的介面與物件與練習建構式注入方法

在這裡，使用建構式注入了 ISayHello 介面地當時實作物件，ISayHello 的實作物件將會於每個原生專案內茶看到，在原生專案內，其類別必須標示 [assembly: Xamarin.Forms.Dependency(typeof(SayHello))]

https://github.com/vulcanlee/XF-Course/tree/master/PrismDS

# PrismUnityApp4

## Prism 核心服務與功能練習

在這裡，您將會學會如何在進行頁面導航的時候，傳遞參數到下個頁面中、如何在新頁面中將參數取得回來、使用深層導航，一次導航到多個頁面；對話窗服務功能的使用、使用相依性服務注入技巧、建構式注入物件。

https://github.com/vulcanlee/XF-Course/tree/master/PrismUnityApp4

# RelativeLayoutLab

## 使用 Xamarin.Forms 的相對版面配置 RelativeLayout

在這裡，您將會看到如何使用 Xamarin.Forms 提供的版面配置 (Layout )的其中一種，相對版面配置 RelativeLayout 的使用方法。

https://github.com/vulcanlee/XF-Course/tree/master/RelativeLayoutLab

# SAPLib

## 使用 Shared 專案，開發原生 Android / iOS / UWP 專案

在這裡使用條件式的編譯符號，定義各平台下要執行的程式碼，您可以透過左上角的下來選單，進行切換

https://github.com/vulcanlee/XF-Course/tree/master/SAPLib

# SimpleListView1

## 練習如何使用 ListView 控制項

建立每個紀錄要用到的類別、使用 ObservableCollection<T>建立要綁定到XAML的集合物件、綁定 SelectedItem 屬性、使用 Behavior 綁定ItemTapped事件與ICommand、設計每筆紀錄要出現的樣貌 ListView.ItemTemplate

https://github.com/vulcanlee/XF-Course/tree/master/SimpleListView1

# TabbedPageLab

## 標籤式頁面 TabbedPage 的使用練習

在這個練習中，您需要在標籤式頁面內，加入多個 ContentPage 項目，並且每個項目一定要定義 Title 屬性，這樣，就完成了標籤式頁面的設計

https://github.com/vulcanlee/XF-Course/tree/master/TabbedPageLab

# TabbedPagePrism

## 在 Prism 下，設計標籤式頁面 TabbedPage 的使用練習

在這個練習中，您需要在標籤式頁面內，加入多個 ContentPage 項目，並且每個項目一定要定義 Title 屬性，這樣，就完成了標籤式頁面的設計

https://github.com/vulcanlee/XF-Course/tree/master/TabbedPagePrism

# TBIVideoLab

## 導航工具列設計範例

這個專案，將會練習如何在導航工具列上，加入導航工具列按鈕，讓這個頁面多了一寫操作命令選擇

https://github.com/vulcanlee/XF-Course/tree/master/TBIVideoLab

# TBIVideoLabImg

## 標籤式頁面 TabbedPage 具有圖片的使用練習

在這個練習中，您需要在標籤式頁面內，加入多個 ContentPage 項目，並且每個項目一定要定義Title 屬性、設定 Icon 屬性，這樣，就完成了標籤式頁面的設計。您需要將圖片檔案複製到原生專案的指定位置內，若每個原生專案的圖片路徑不太相同，可以使用 OnPlatform x:TypeArguments 來指定個平台的圖片位置

https://github.com/vulcanlee/XF-Course/tree/master/TBIVideoLabImg

# UserCtrlEntry

## 這裡將展示如何自行客製一個使用者控制項(具有資料綁定與處理邏輯)

當使用者所輸入文字長度超過使用者控制項的定義，其右方的圖片，將會變成綠色，告知使用者，您輸入的文字內容符合規定；在這裡，您可以針對不同條件做出不同的條件檢查，也可以使用正規表示式來判斷使用者輸入的內容是否符合規範

宣告一個使用者控制項，並且綁定 ViewModel 內的 Name Property，設定這個文字輸入盒，具有輸入字串長度檢查能力

https://github.com/vulcanlee/XF-Course/tree/master/UserCtrlEntry

# XFNaviService

## 這是個綜合演練範例，包含了導航頁面、深度導航、導航抽屜的各種測試

從這裡，您可以了解到一個綜合式的應用開發，該如何解決這些問題。

https://github.com/vulcanlee/XF-Course/tree/master/XFNaviService

