   M S B A M L   `   `   `  ����C  ?BuBuLmao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BuBuLmaoBuBuLmao  5   	   &     BuBuLmao.LevelView.PlayingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BuBuLmao     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  ..\Asset\icon.ico��5	   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � Title$ 	Easy Mode��5   	   $	��768��6   $
��1366��6(    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�5   	    � 	Resources 5         	placement �� 
StartPoint � Color	 � Offset
 �� 
TargetType  ImagePlacement �� Property �� Value O� 	GlowColor O� GlowSize��%R  &	        &	 �     7   �� 5   
   $
 0, 0&�60   .��5      � $ LightSlateGray��6   $		 0.1Q�62   � 5      $ White��6   $		 0.9Q�6)   5      �� 5   
   "
 ��6   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ Stretch=�62   �� 5       � ��$	 120��6&   �� 5       � ��$	 120��6'   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��8   6+   �� 5        �@J�	AllowDrop . 6*   �� 5!       �@J�BitmapEffect 5"      O� 5#      $
 Gold��6,   $ 5Q�6=   5%      -   5        5(      5)      .��5*      � ��5+   
   �� 5,       �� ImageSource$&  /Asset/Background/EasyWindow.png��6   .+�5/   
   � -   5         �Name$
 Eyes��5/      $��975,176,111,453.4q�6    � ColumnDefinitions 50      �� 51      �� 52      .+�55      � $��0��6   .+�56      �� $��../Asset/Button/Laser.png��6   $��-100,-69,-148.2,-65.2q�6;   57      � 59      $��1��6   .+�5:      �� $��../Asset/Button/Laser.png��6   $��-18,-64,-230.2,-70.2q�6;   5;      5<      �� 5>   
   -   5        ���	#FF686868$��5q�5?   %    � ToolTip$- 'MaterialDesignFloatingActionLightButton��5@      $��1243,626,0,0.4q�6?   .��5A      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Help=�5B      $��96��6   $��96��6(   ���	#FFFD414164    5C      ��%`   '��       �� 5D      "
 ��6   .�5E      ��  �@��CornerRadius$	 100��65   5F      5G      5H      �� 5J   
   -   5         ��Name$ 	itemsList��5J      $��5q�6%   $��Stretch=�69   $��Stretch=�6W   $
��auto��5K      $
��auto��6     
listPuzzle#��[ 5M      $��663,51,528,52.4q�5N       � Cursor$
 Hand��6+    � DataContext 5L   S   �� ��6k   �� 5N   +   � 5Q   
   $	��360��6   $	��360��6   $��187,188,811,189q�6)    5S      �� 5T      $��* �6#   �� 5U      $��* �6#   �� 5V      $��* �6#    � RowDefinitions 5X      �� 5Y      $��* �6    �� 5Z      $��* �6    �� 5[      $��* �6    .+�5_      �� -   5        $��puzzlePart1��5_   2   $��0��6   $��0��6%   
 � Tag$ 0��6E   #��[ 5`      �� 5a      -   5        $��puzzlePart2��5a   2   $��1��6   $��0��6%   $ 1��6E   #��[ 5b      �� 5c      -   5        $��puzzlePart3��5c   2   $��2��6   $��0��6%   $ 2��6E   #��[ 5d      �� 5f      -   5        $��puzzlePart4��5f   2   $��0��6   $��1��6%   $ 3��6E   #��[ 5g      �� 5h      -	   5        $��puzzlePart5��5h   2   $��1��6   $��1��6%   $ 4��6E   #��[ 5i      �� 5j      -
   5        $��puzzlePart6��5j   2   $��2��6   $��1��6%   $ 5��6E   #��[ 5k      �� 5m      -   5        $��puzzlePart7��5m   2   $��0��6   $��2��6%   $ 6��6E   #��[ 5n      �� 5o      -   5        $��puzzlePart8��5o   2   $��1��6   $��2��6%   $ 7��6E   #��[ 5p      �� 5q      -   5        $��puzzlePart9��5q   2   $��2��6   $��2��6%   $ 8��6E   #��[ 5r      5t      5u      5v      