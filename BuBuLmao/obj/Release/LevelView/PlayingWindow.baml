   M S B A M L   `   `   `  ���� C  ?BuBuLmao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BuBuLmaoBuBuLmao  &     BuBuLmao.LevelView.PlayingWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:BuBuLmao     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Icon$  ..\Asset\icon.ico��$��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=� � Title$ 	Easy Mode��$	��768��$
��1366�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=� � 	Resources    	placement �� 
StartPoint � Color	 � Offset
 �� 
TargetType  ImagePlacement �� Property �� Value O� 	GlowColor O� GlowSize��%e  &	        &	 R     7   �� $
 0, 0&�.��� $ LightSlateGray��$		 0.1Q�� $ White��$		 0.9Q��� "
 ��.���  � ��$ Stretch=���  � ��$ Stretch=���  � ��$	 120����  � ��$	 120����  �@�Cursor$
 Hand����  � ��8   ��  �@J�	AllowDrop . ��  �@J�BitmapEffect O� $
 Gold��$ 5Q�-   .��� ����  �� ImageSource$&  /Asset/Background/EasyWindow.png��.+�� -    �Name$
 Eyes��$��975,176,111,453.4q� � ColumnDefinitions �� �� .+�� $��0��.+��� $��../Asset/Button/Laser.png��$��-100,-69,-148.2,-65.2q�� $��1��.+��� $��../Asset/Button/Laser.png��$��-18,-64,-230.2,-70.2q��� -   ���	#FF686868$��5q� � ToolTip$- 'MaterialDesignFloatingActionLightButton��$��1243,626,0,0.4q�.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Help=�$��96��$��96�����	#FFFD4141 ��%;   '��       �� "
 ��.���  �@��CornerRadius$	 100���� -    ��Name$ 	itemsList��$��5q�$��Stretch=�$��Stretch=�$
��auto��$
��auto��  
listPuzzle#��[ $��663,51,528,52.4q� � Cursor$
 Hand�� � DataContext �� ���� � $	��360��$	��360��$��187,188,811,189q� �� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� -   $��puzzlePart1��$��0��$��0��
 � Tag$ 0��#��[ �� -   $��puzzlePart2��$��1��$��0��$ 1��#��[ �� -   $��puzzlePart3��$��2��$��0��$ 2��#��[ �� -   $��puzzlePart4��$��0��$��1��$ 3��#��[ �� -	   $��puzzlePart5��$��1��$��1��$ 4��#��[ �� -
   $��puzzlePart6��$��2��$��1��$ 5��#��[ �� -   $��puzzlePart7��$��0��$��2��$ 6��#��[ �� -   $��puzzlePart8��$��1��$��2��$ 7��#��[ �� -   $��puzzlePart9��$��2��$��2��$ 8��#��[ 