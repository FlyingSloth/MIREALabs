object Form1: TForm1
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = #1057#1086#1076#1077#1088#1078#1072#1090#1077#1083#1100#1085#1072#1103' '#1074#1072#1083#1080#1076#1085#1086#1089#1090#1100' '#1090#1077#1089#1090#1072
  ClientHeight = 463
  ClientWidth = 717
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 4
    Width = 97
    Height = 13
    Caption = #1050#1086#1083#1080#1095#1077#1089#1090#1074#1086' '#1094#1077#1083#1077#1081':'
  end
  object Label2: TLabel
    Left = 8
    Top = 31
    Width = 119
    Height = 13
    Caption = #1050#1086#1083#1080#1095#1077#1089#1090#1074#1086' '#1101#1082#1089#1087#1077#1088#1090#1086#1074':'
  end
  object Label3: TLabel
    Left = 8
    Top = 288
    Width = 213
    Height = 13
    Caption = #1052#1072#1090#1088#1080#1094#1072' '#1082#1086#1101#1092#1092#1080#1094#1080#1077#1085#1090#1086#1074' '#1082#1086#1085#1075#1088#1091#1077#1085#1090#1085#1086#1089#1090#1080
  end
  object Label6: TLabel
    Left = 8
    Top = 52
    Width = 109
    Height = 13
    Caption = #1050#1086#1083#1080#1095#1077#1089#1090#1074#1086' '#1079#1072#1076#1072#1085#1080#1081':'
  end
  object teTarget: TEdit
    Left = 133
    Top = 4
    Width = 57
    Height = 21
    NumbersOnly = True
    TabOrder = 2
  end
  object teExp: TEdit
    Left = 133
    Top = 27
    Width = 57
    Height = 21
    NumbersOnly = True
    TabOrder = 3
  end
  object pbConstruct: TButton
    Left = 206
    Top = 25
    Width = 75
    Height = 25
    Caption = #1055#1086#1089#1090#1088#1086#1080#1090#1100
    TabOrder = 4
    OnClick = pbConstructClick
  end
  object teCount: TEdit
    Left = 133
    Top = 50
    Width = 57
    Height = 21
    TabOrder = 5
  end
  object pbCalc: TButton
    Left = 487
    Top = 304
    Width = 75
    Height = 25
    Caption = #1055#1086#1089#1095#1080#1090#1072#1090#1100
    TabOrder = 6
    OnClick = pbCalcClick
  end
  object sgMain: TStringGrid
    Left = 8
    Top = 81
    Width = 703
    Height = 201
    ColCount = 10
    DefaultColWidth = 65
    DefaultRowHeight = 15
    RowCount = 9
    FixedRows = 2
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goEditing]
    TabOrder = 0
  end
  object sgRes: TStringGrid
    Left = 8
    Top = 304
    Width = 473
    Height = 153
    ColCount = 4
    DefaultColWidth = 75
    DefaultRowHeight = 15
    RowCount = 9
    TabOrder = 1
    RowHeights = (
      15
      15
      15
      15
      15
      15
      15
      15
      15)
  end
  object pbSave: TButton
    Left = 487
    Top = 430
    Width = 75
    Height = 25
    Caption = #1057#1086#1093#1088#1072#1085#1080#1090#1100
    TabOrder = 7
    OnClick = pbSaveClick
  end
end
