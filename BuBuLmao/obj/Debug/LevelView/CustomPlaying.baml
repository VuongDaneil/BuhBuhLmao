   M S B A M L   `   `   `  ����C  ?BuBuLmao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BuBuLmaoBuBuLmao  5   	   &     BuBuLmao.LevelView.CustomPlaying   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BuBuLmao     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     � Icon$  ..\Asset\icon.ico��5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � Title$ 	Easy Mode��5   	   $	��768��6   $
��1366��6(    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�5   	    � 	Resources 5         	placement �� 
StartPoint � Color	 � Offset
 �� 
TargetType  ImagePlacement �� Property �� Value O� 	GlowColor O� GlowSize��%R  &	        &	 �     7   �� 5   
   $
 0, 0&�60   .��5      � $ LightSlateGray��6   $		 0.1Q�62   � 5      $ White��6   $		 0.9Q�6)   5      �� 5   
   "
 ��6   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ Stretch=�62   �� 5       � ��$	 120��6&   �� 5       � ��$	 120��6'   �� 5       �@�Cursor$
 Hand��6'   �� 5        � ��8   6+   �� 5!       �@J�	AllowDrop . 6*   �� 5"       �@J�BitmapEffect 5#      O� 5$      $
 Gold��6,   $ 5Q�6=   5&      -   5        5)      5*      .��5+      � ��5,   
   �� 5-       �� ImageSource$&  /Asset/Background/EasyWindow.png��6   .+�50   
   � -   5         �Name$
 Eyes��50      $��975,176,111,453.4q�6    � ColumnDefinitions 51      �� 52      �� 53      .+�56      � $��0��6   .+�57      �� $��../Asset/Button/Laser.png��6   $��-100,-69,-148.2,-65.2q�6;   58      � 5:      $��1��6   .+�5;      �� $��../Asset/Button/Laser.png��6   $��-18,-64,-230.2,-70.2q�6;   5<      5=      �� 5?   
   -   5        ���	#FF686868$��5q�5@   %    � ToolTip$- 'MaterialDesignFloatingActionLightButton��5A      $��1243,626,0,0.4q�6?   .��5B      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Help=�5C      $��96��6   $��96��6(    5D      ��%`   '��       �� 5E      "
 ��6   .�5F      ��  �@��CornerRadius$	 100��65   5G      5H      5I      �� 5K   
   -   5         ��Name$ 	itemsList��5K      $��5q�6%   $��Stretch=�69   $��Stretch=�6W   $
��auto��5L      $
��auto��6     
listPuzzle#��[ 5N      $��663,51,528,52.4q�5O       � Cursor$
 Hand��6+    � DataContext 5M   S   �� ��6k   �� 5O   +   � 5R   
   $	��360��6   $	��360��6   $��187,188,811,189q�6)    5T      �� 5U      $��* �6#   �� 5V      $��* �6#   �� 5W      $��* �6#    � RowDefinitions 5Y      �� 5Z      $��* �6    �� 5[      $��* �6    �� 5\      $��* �6    .+�5`      �� -   5        $��puzzlePart1��5`   2   $��0��6   $��0��6%   
 � Tag$ 0��6E   #��[ 5a      �� 5b      -   5        $��puzzlePart2��5b   2   $��1��6   $��0��6%   $ 1��6E   #��[ 5c      �� 5d      -   5        $��puzzlePart3��5d   2   $��2��6   $��0��6%   $ 2��6E   #��[ 5e      �� 5g      -   5        $��puzzlePart4��5g   2   $��0��6   $��1��6%   $ 3��6E   #��[ 5h      �� 5i      -	   5        $��puzzlePart5��5i   2   $��1��6   $��1��6%   $ 4��6E   #��[ 5j      �� 5k      -
   5        $��puzzlePart6��5k   2   $��2��6   $��1��6%   $ 5��6E   #��[ 5l      �� 5n      -   5        $��puzzlePart7��5n   2   $��0��6   $��2��6%   $ 6��6E   #��[ 5o      �� 5p      -   5        $��puzzlePart8��5p   2   $��1��6   $��2��6%   $ 7��6E   #��[ 5q      �� 5r      -   5        $��puzzlePart9��5r   2   $��2��6   $��2��6%   $ 8��6E   #��[ 5s      5u      5v      5w      