   M S B A M L   `   `   `  ����H  DNAudioWpfDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NAudioWpfDemoNAudioWpfDemo  5      )    #NAudioWpfDemo.AudioPlaybackDemoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:NAudioWpfDemo     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   Select Visualization:6,   �� 5       �� DisplayMemberPath$
 Name��6>   $��31��6�   ��6   �� *Visualizations+ �� SelectedItem 6W   �� *SelectedVisualization+ �� Mode$ TwoWay=�6�   �� 5      -   5         ��Name$ cboPorts��5      $	��155��6)   65   5      �� 5   
   $��1��6=   ��6   �� *Visualization+6=   �� 5   
   $ 
Horizontal=�6   $��2��6.   .+�5      �� $��2q�69   $��4q�6D    � ToolTip$
 Open��6P   ��6   �� *OpenFileCommand+.��6_   Open5      �� 5      $��2q�65   $
 Stop��6@   ��6   �� *StopCommand+.��5      �� 
����  �$��15��6,   $��15��67   $��3q�6C    �� RadiusX$ 2��6N    �� RadiusY$ 2��6Z   5      �� 5      $��2q�66   $ Pause��6A   ��6   �� *PauseCommand+.��5      F� 
���  ��$��15��6%   $��15��60   $��3q�6<   O����        �@B     �@B @B �    @B ���     ���-     ���- @B р� @B 		 �� Stretch$
	 Fill=�6x   
 �� StrokeLineJoin$
 Round=�6�   5      �� 5      $��2q�65   $
 Play��6@   ��6   �� *PlayCommand+.��5       F� 
��� d �$��3q�6(   $��15��63   $��15��6>   "����        �@B @B �    �� 	$
	 Fill=�6e   $
 Round=�6t   5!      �� 5"      -   5         ��Name$ 	sldrGroup��5"       �� IsSnapToTickEnabled .  �� AutoToolTipPrecision$ 1��6C    �� AutoToolTipPlacement$ BottomRight=�5#       � Minimum$ 0Q�68    � Maximum$ 4Q�6D   $	��165��6P   6\   �� 5%      -   5        $ sldrPattern��5%       . $ 1��6E   $ BottomRight=�5&      $ 0Q�68   $ 15Q�6D   $	��165��6Q   5'      5(      5)      5*      