   M S B A M L   `   `   `  ����N  JTheViandaProject v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TheViandaProject.Vistas.InsumosTheViandaProject.Vistas.Insumos  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   :    4TheViandaProject.Vistas.Insumos.AdministradorInsumos   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TheViandaProject.Vistas.Insumos     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Gestionar insumos��5	   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�5
      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgInsumos��5      $��0,42,0,0q�6'      AutoGenerateColumns$ False��69      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Nombre+  5      $ Descripcion��6%   $ * 6:    6D   �� *Descripcion+  5      $ Costo��6%   $	 100 64    6@   �� *Costo+5      �� 5   
   -   5        $��Registrar nuevo��5      $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   $	��127��6q   6}   �� 5   
   -   5        $��Editar��5      $
��Left=�6"   $��
142,10,0,0q�6=   $	��Top=�6Q   $	��127��6i   6u   �� 5   
   -   5        $��	Habilitar��5      $
��Left=�6%   $��
274,10,0,0q�6@   $	��Top=�6T   $	��127��6l   6x   �� 5   
   -   5        $��Deshabilitar��5      $
��Left=�6(   $��
406,10,0,0q�6C   $	��Top=�6W   $	��127��6o   6{   5      5      