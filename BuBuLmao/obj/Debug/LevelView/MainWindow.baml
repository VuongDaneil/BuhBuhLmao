   M S B A M L   `   `   `  ����C  ?BuBuLmao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BuBuLmaoBuBuLmao  5   	   #    BuBuLmao.LevelView.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BuBuLmao     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  ..\Asset\icon.ico��5   	    � Title$ BuBu LMAO!!��5   	   $	��768��6   $
��1366��6*    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� Source�� 5   
   $ ../Resources/myRS.xaml?�6   %    .��5      � ��5   
   �� 5       �� ImageSource$" /Asset/Background/MenuBG.jpg��6   .+�5   
   � $��270,280,684,31.4q�6    � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5!      � $��0��6   $��-45,0,-45,0.4q�6    .+�5"      �� -   5         ��Name$ Playbtn��5"         MyButtonStyle#��[  6*   
�������$��58,5,58.4,5q�6z   .��5#      �� 	 � Cursor$
	 Hand��5$      $��/Asset/Button/play.png��5%      $	��132��69   $	��172��6F     btnImage#��[ 5&      5'      5(      � 5+      $��-45,142,-45,142.2q�6   $��3��6.   .+�5,      �� -   5        $ 
Settingbtn��5,      #��[  6-   
�������$��57,5,58.4,5q�6�   .��5-      �� $
	 Hand��5.      $��/Asset/Button/Setting.png��5/      $	��121��6<   $	��172��6I   #��[ 50      52      53      � 55      $��2��6   $��-45,0.2q�6    .+�56      �� -   5        $ Quitbtn��56      #��[  6*   
�������$��57,5,58.4,5q�6z   .��57      �� $
	 Hand��58      $��/Asset/Button/quit.png��59      $	��121��69   $	��172��6F   #��[ 5:      
 J� OpacityMask

 �����6>   5;      5<      5>      � 5@   
   $��32,367,1108,155.4q�6    5A      �� 5B      $��3* �6    �� 5C      $��* �6    .+�5E      � $��0��6   .+�5F      �� -   5          MDesign# [ 5G       � ToolTip$" MaterialDesignFlatDarkButton��5H      $
��Auto��5I      ��6#   Z� ��69   Z� .��5J      �� $��../Asset/Button/Rank.png��6   $	��207��6>   $	��207��6J   $��Center=�5K      $��Center=�61   5L      5M      � 5N      $��1��6   .+�5O      �� $��25(�6   $
��Bold"�6*    �� TextAlignment$ Center=�6<   ���	#FFFFF700$��
0,-8,0,8.4q�6j   
HIGH SCORE6�   5P      5Q      5R      5S      