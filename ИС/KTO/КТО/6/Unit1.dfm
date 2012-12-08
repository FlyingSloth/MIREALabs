object Form1: TForm1
  Left = 0
  Top = 0
  Caption = #1058#1077#1089#1090#1080#1088#1086#1074#1072#1085#1080#1077
  ClientHeight = 365
  ClientWidth = 826
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object GroupBox1: TGroupBox
    Left = -3
    Top = 0
    Width = 827
    Height = 81
    Caption = #1057#1090#1091#1076#1077#1085#1090':'
    TabOrder = 0
    object Label1: TLabel
      Left = 16
      Top = 16
      Width = 27
      Height = 13
      Caption = #1060#1048#1054':'
    end
    object Label2: TLabel
      Left = 16
      Top = 35
      Width = 40
      Height = 13
      Caption = #1043#1088#1091#1087#1087#1072':'
    end
    object Label3: TLabel
      Left = 16
      Top = 54
      Width = 97
      Height = 13
      Caption = #1044#1072#1090#1072' '#1088#1077#1075#1080#1089#1090#1088#1072#1094#1080#1080':'
    end
    object lblFIO: TLabel
      Left = 199
      Top = 16
      Width = 16
      Height = 13
      Caption = '----'
    end
    object lblGroup: TLabel
      Left = 199
      Top = 35
      Width = 16
      Height = 13
      Caption = '----'
    end
    object lblDate: TLabel
      Left = 199
      Top = 54
      Width = 16
      Height = 13
      Caption = '----'
    end
    object btnEnter: TButton
      Left = 717
      Top = 11
      Width = 96
      Height = 25
      Caption = #1042#1093#1086#1076
      TabOrder = 0
      OnClick = btnEnterClick
    end
    object btnRegNew: TButton
      Left = 717
      Top = 49
      Width = 96
      Height = 25
      Caption = #1056#1077#1075#1080#1089#1090#1088#1072#1094#1080#1103
      TabOrder = 1
      OnClick = btnRegNewClick
    end
  end
  object gbNew: TGroupBox
    Left = 0
    Top = 87
    Width = 816
    Height = 122
    Caption = #1053#1086#1074#1099#1081' '#1087#1086#1083#1100#1079#1086#1074#1072#1090#1077#1083#1100':'
    TabOrder = 1
    Visible = False
    object Label4: TLabel
      Left = 16
      Top = 51
      Width = 27
      Height = 13
      Caption = #1060#1048#1054':'
    end
    object Label5: TLabel
      Left = 16
      Top = 78
      Width = 40
      Height = 13
      Caption = #1043#1088#1091#1087#1087#1072':'
    end
    object Label6: TLabel
      Left = 16
      Top = 24
      Width = 34
      Height = 13
      Caption = #1064#1080#1092#1088':'
    end
    object edtFIO: TEdit
      Left = 62
      Top = 51
      Width = 291
      Height = 21
      TabOrder = 0
    end
    object edtGroup: TEdit
      Left = 62
      Top = 78
      Width = 99
      Height = 21
      TabOrder = 1
    end
    object btnReg: TButton
      Left = 717
      Top = 94
      Width = 96
      Height = 25
      Caption = #1057#1086#1093#1088#1072#1085#1080#1090#1100
      TabOrder = 2
      OnClick = btnRegClick
    end
    object edtNewPass: TEdit
      Left = 62
      Top = 24
      Width = 99
      Height = 21
      NumbersOnly = True
      TabOrder = 3
    end
  end
  object gbEnter: TGroupBox
    Left = 0
    Top = 87
    Width = 289
    Height = 58
    Caption = #1042#1093#1086#1076
    TabOrder = 2
    Visible = False
    object Label7: TLabel
      Left = 16
      Top = 24
      Width = 34
      Height = 13
      Caption = #1064#1080#1092#1088':'
    end
    object edtPassEnter: TEdit
      Left = 62
      Top = 24
      Width = 99
      Height = 21
      NumbersOnly = True
      TabOrder = 0
    end
    object btnPassEnter: TButton
      Left = 177
      Top = 19
      Width = 96
      Height = 25
      Caption = #1042#1093#1086#1076
      TabOrder = 1
      OnClick = btnPassEnterClick
    end
  end
  object gbQ1: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'1'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
    object Label8: TLabel
      Left = 12
      Top = 12
      Width = 170
      Height = 13
      Caption = #1042#1099#1073#1077#1088#1080#1090#1077' '#1087#1088#1072#1074#1080#1083#1100#1085#1099#1081' '#1086#1090#1074#1077#1090
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label9: TLabel
      Left = 12
      Top = 31
      Width = 201
      Height = 13
      Caption = #1055#1088#1080' '#1074#1099#1087#1086#1083#1085#1077#1085#1080#1080'  '#1082#1086#1076#1072' '#1087#1088#1086#1075#1088#1072#1084#1084#1099
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label10: TLabel
      Left = 14
      Top = 50
      Width = 58
      Height = 13
      Caption = 'int i=1,s=0;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label11: TLabel
      Left = 14
      Top = 69
      Width = 75
      Height = 13
      Caption = 'while (++i<=3)'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label12: TLabel
      Left = 14
      Top = 88
      Width = 27
      Height = 13
      Caption = 's+=i;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label13: TLabel
      Left = 14
      Top = 107
      Width = 46
      Height = 13
      Caption = 'cout<<s;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label14: TLabel
      Left = 16
      Top = 126
      Width = 104
      Height = 13
      Caption = #1073#1091#1076#1077#1090' '#1074#1099#1074#1077#1076#1077#1085#1086':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object rb11: TRadioButton
      Left = 16
      Top = 145
      Width = 40
      Height = 17
      Caption = '6'
      TabOrder = 0
    end
    object rb12: TRadioButton
      Left = 80
      Top = 145
      Width = 40
      Height = 17
      Caption = '5'
      TabOrder = 1
    end
    object rb13: TRadioButton
      Left = 152
      Top = 144
      Width = 40
      Height = 17
      Caption = '8'
      TabOrder = 2
    end
    object rb14: TRadioButton
      Left = 216
      Top = 144
      Width = 41
      Height = 17
      Caption = '2 5'
      TabOrder = 3
    end
    object rb15: TRadioButton
      Left = 288
      Top = 144
      Width = 113
      Height = 17
      Caption = '2 5 8'
      TabOrder = 4
    end
    object pbAccept1: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 5
      OnClick = pbAccept1Click
    end
    object bpNext1: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 6
      OnClick = bpNext1Click
    end
  end
  object pbStart: TButton
    Left = 428
    Top = 87
    Width = 171
    Height = 25
    Caption = #1053#1072#1095#1072#1090#1100' '#1090#1077#1089#1090#1080#1088#1086#1074#1072#1085#1080#1077
    TabOrder = 4
    OnClick = pbStartClick
  end
  object gbQ2: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'2'
    TabOrder = 5
    object Label20: TLabel
      Left = 15
      Top = 12
      Width = 170
      Height = 13
      Caption = #1042#1099#1073#1077#1088#1080#1090#1077' '#1087#1088#1072#1074#1080#1083#1100#1085#1099#1081' '#1086#1090#1074#1077#1090
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label21: TLabel
      Left = 18
      Top = 31
      Width = 325
      Height = 13
      Caption = #1050#1072#1082#1086#1081' '#1086#1087#1077#1088#1072#1090#1086#1088' '#1103#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1089' '#1087#1086#1089#1090#1091#1089#1083#1086#1074#1080#1077#1084'?'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object rb21: TRadioButton
      Left = 16
      Top = 50
      Width = 353
      Height = 17
      Caption = 'for'
      TabOrder = 0
    end
    object rb22: TRadioButton
      Left = 16
      Top = 73
      Width = 369
      Height = 28
      Caption = 'while'
      TabOrder = 1
      WordWrap = True
    end
    object rb23: TRadioButton
      Left = 16
      Top = 107
      Width = 297
      Height = 17
      Caption = 'do'
      TabOrder = 2
    end
    object rb24: TRadioButton
      Left = 16
      Top = 130
      Width = 369
      Height = 33
      Caption = 'break'
      TabOrder = 3
      WordWrap = True
    end
    object rb25: TRadioButton
      Left = 16
      Top = 169
      Width = 321
      Height = 17
      Caption = 'continue'
      TabOrder = 4
    end
    object pbAccept2: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 5
      OnClick = pbAccept2Click
    end
    object pbNext2: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 6
      OnClick = pbNext2Click
    end
    object pbPrev2: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 7
      OnClick = pbPrev2Click
    end
  end
  object gbQ3: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'3'
    TabOrder = 6
    object Label15: TLabel
      Left = 12
      Top = 12
      Width = 250
      Height = 13
      Caption = #1042#1099#1073#1077#1088#1080#1090#1077' '#1085#1077#1089#1082#1086#1083#1100#1082#1086' '#1087#1088#1072#1074#1080#1083#1100#1085#1099#1093' '#1086#1090#1074#1077#1090#1086#1074
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label16: TLabel
      Left = 12
      Top = 31
      Width = 264
      Height = 13
      Caption = #1059#1082#1072#1078#1080#1090#1077' '#1094#1080#1082#1083#1099', '#1103#1074#1083#1103#1102#1097#1080#1077#1089#1103' '#1073#1077#1089#1082#1086#1085#1077#1095#1085#1099#1084#1080
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object pbAccept3: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 0
      OnClick = pbAccept3Click
    end
    object chk31: TCheckBox
      Left = 16
      Top = 56
      Width = 97
      Height = 17
      Caption = 'for(;;) { i++; }'
      TabOrder = 1
    end
    object chk32: TCheckBox
      Left = 16
      Top = 79
      Width = 244
      Height = 17
      Caption = 'for(int i=0;i>0;i++) { cout << i << endl; }'
      TabOrder = 2
    end
    object chk33: TCheckBox
      Left = 16
      Top = 102
      Width = 185
      Height = 17
      Caption = 'while(!true ||false) { break; }'
      TabOrder = 3
    end
    object chk34: TCheckBox
      Left = 16
      Top = 125
      Width = 169
      Height = 17
      Caption = 'while(true) { continue; }'
      TabOrder = 4
    end
    object chk35: TCheckBox
      Left = 16
      Top = 148
      Width = 233
      Height = 17
      Caption = 'do { i = i+5; } while(!true) '
      TabOrder = 5
    end
    object pbPrev3: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 6
      OnClick = pbPrev3Click
    end
    object pbNext3: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 7
      OnClick = pbNext3Click
    end
  end
  object gbQ4: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'4'
    TabOrder = 7
    object Label17: TLabel
      Left = 12
      Top = 14
      Width = 250
      Height = 13
      Caption = #1042#1099#1073#1077#1088#1080#1090#1077' '#1085#1077#1089#1082#1086#1083#1100#1082#1086' '#1087#1088#1072#1074#1080#1083#1100#1085#1099#1093' '#1086#1090#1074#1077#1090#1086#1074
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label18: TLabel
      Left = 12
      Top = 31
      Width = 296
      Height = 13
      Caption = #1050#1072#1082#1080#1077' '#1086#1087#1077#1088#1072#1090#1086#1088#1099', '#1103#1074#1083#1103#1102#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1072#1084#1080' '#1094#1080#1082#1083#1086#1074'.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object chk41: TCheckBox
      Left = 16
      Top = 56
      Width = 97
      Height = 17
      Caption = 'break'
      TabOrder = 0
    end
    object chk42: TCheckBox
      Left = 16
      Top = 79
      Width = 97
      Height = 17
      Caption = 'for'
      TabOrder = 1
    end
    object chk43: TCheckBox
      Left = 16
      Top = 102
      Width = 129
      Height = 17
      Caption = 'do'
      TabOrder = 2
    end
    object chk44: TCheckBox
      Left = 16
      Top = 125
      Width = 97
      Height = 17
      Caption = 'else if'
      TabOrder = 3
    end
    object chk45: TCheckBox
      Left = 16
      Top = 148
      Width = 97
      Height = 17
      Caption = 'switch'
      TabOrder = 4
    end
    object pbAccept4: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 5
      OnClick = pbAccept4Click
    end
    object pbPrev4: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 6
      OnClick = pbPrev4Click
    end
    object pbNext4: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 7
      OnClick = pbNext4Click
    end
  end
  object gbQ5: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'5'
    TabOrder = 8
    Visible = False
    object Label22: TLabel
      Left = 12
      Top = 12
      Width = 249
      Height = 13
      Caption = #1057#1086#1087#1086#1089#1090#1072#1074#1100#1090#1077' '#1086#1087#1077#1088#1072#1090#1086#1088#1099' '#1089' '#1080#1093' '#1085#1072#1079#1085#1072#1095#1077#1085#1080#1077#1084
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label25: TLabel
      Left = 16
      Top = 55
      Width = 27
      Height = 13
      Caption = '1) for'
    end
    object Label23: TLabel
      Left = 16
      Top = 77
      Width = 40
      Height = 13
      Caption = '2) break'
    end
    object Label26: TLabel
      Left = 16
      Top = 96
      Width = 54
      Height = 13
      Caption = '3) continue'
    end
    object Label27: TLabel
      Left = 16
      Top = 115
      Width = 25
      Height = 13
      Caption = '4) do'
    end
    object Label28: TLabel
      Left = 96
      Top = 55
      Width = 216
      Height = 13
      Caption = '1. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1087#1088#1077#1088#1099#1074#1072#1085#1103' '#1094#1080#1082#1083#1072
    end
    object Label29: TLabel
      Left = 96
      Top = 74
      Width = 284
      Height = 13
      Caption = '2. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1086#1073#1088#1072#1097#1077#1085#1080#1103' '#1082' '#1080#1085#1076#1077#1082#1089#1091' '#1084#1072#1089#1089#1080#1074#1072' '
    end
    object Label30: TLabel
      Left = 96
      Top = 93
      Width = 312
      Height = 13
      Caption = '3. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1087#1077#1088#1077#1093#1086#1076#1072' '#1085#1072' '#1089#1083#1077#1076#1091#1102#1097#1080#1081' '#1096#1072#1075' '#1094#1080#1082#1083#1072' '
    end
    object Label31: TLabel
      Left = 96
      Top = 112
      Width = 199
      Height = 13
      Caption = '4. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1087#1088#1077#1076#1091#1089#1083#1086#1074#1080#1077#1084
    end
    object Label32: TLabel
      Left = 96
      Top = 131
      Width = 238
      Height = 13
      Caption = '5. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1094#1080#1082#1083#1072' '#1089' '#1087#1086#1089#1090#1091#1089#1083#1086#1074#1080#1077#1084
    end
    object Label33: TLabel
      Left = 96
      Top = 150
      Width = 181
      Height = 13
      Caption = '6. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1074#1077#1090#1074#1083#1077#1085#1080#1103
    end
    object Label34: TLabel
      Left = 96
      Top = 169
      Width = 257
      Height = 13
      Caption = '7. '#1071#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1074#1086#1079#1074#1088#1072#1097#1072#1102#1097#1080#1084' '#1079#1085#1072#1095#1077#1085#1080#1077
    end
    object Label35: TLabel
      Left = 35
      Top = 219
      Width = 6
      Height = 13
      Caption = '1'
    end
    object Label36: TLabel
      Left = 107
      Top = 219
      Width = 6
      Height = 13
      Caption = '2'
    end
    object Label37: TLabel
      Left = 168
      Top = 220
      Width = 6
      Height = 13
      Caption = '3'
    end
    object Label38: TLabel
      Left = 231
      Top = 220
      Width = 6
      Height = 13
      Caption = '4'
    end
    object Label66: TLabel
      Left = 16
      Top = 31
      Width = 60
      Height = 13
      Caption = #1054#1087#1077#1088#1072#1090#1086#1088':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label67: TLabel
      Left = 96
      Top = 31
      Width = 72
      Height = 13
      Caption = #1053#1072#1079#1085#1072#1095#1077#1085#1080#1077':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object teQ51: TEdit
      Left = 15
      Top = 192
      Width = 49
      Height = 21
      BiDiMode = bdLeftToRight
      NumbersOnly = True
      ParentBiDiMode = False
      TabOrder = 0
    end
    object teQ52: TEdit
      Left = 83
      Top = 192
      Width = 49
      Height = 21
      BiDiMode = bdLeftToRight
      NumbersOnly = True
      ParentBiDiMode = False
      TabOrder = 1
    end
    object teQ53: TEdit
      Left = 147
      Top = 192
      Width = 49
      Height = 21
      BiDiMode = bdLeftToRight
      NumbersOnly = True
      ParentBiDiMode = False
      TabOrder = 2
    end
    object teQ54: TEdit
      Left = 211
      Top = 192
      Width = 49
      Height = 21
      BiDiMode = bdLeftToRight
      NumbersOnly = True
      ParentBiDiMode = False
      TabOrder = 3
    end
    object Button2: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 4
      OnClick = Button2Click
    end
    object Button5: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 5
      OnClick = Button5Click
    end
    object Button6: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 6
      OnClick = Button6Click
    end
  end
  object gbQ6: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'6'
    TabOrder = 9
    Visible = False
    object Label40: TLabel
      Left = 14
      Top = 18
      Width = 295
      Height = 13
      Caption = #1057#1086#1087#1086#1089#1090#1072#1074#1100#1090#1077' '#1086#1087#1077#1088#1072#1090#1086#1088#1099' '#1089' '#1080#1093' '#1074#1077#1088#1085#1099#1084' '#1089#1080#1085#1090#1072#1082#1089#1080#1089#1086#1084
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label39: TLabel
      Left = 14
      Top = 57
      Width = 37
      Height = 13
      Caption = '1) while'
    end
    object Label42: TLabel
      Left = 14
      Top = 76
      Width = 27
      Height = 13
      Caption = '2) for'
    end
    object Label43: TLabel
      Left = 14
      Top = 95
      Width = 25
      Height = 13
      Caption = '3) do'
    end
    object Label44: TLabel
      Left = 100
      Top = 54
      Width = 176
      Height = 13
      Caption = '1. do '#1086#1087#1077#1088#1072#1090#1086#1088' while('#1074#1099#1088#1072#1078#1077#1085#1080#1077'); '
    end
    object Label45: TLabel
      Left = 100
      Top = 73
      Width = 176
      Height = 13
      Caption = '2. do while('#1074#1099#1088#1072#1078#1077#1085#1080#1077'); '#1086#1087#1077#1088#1072#1090#1086#1088' '
    end
    object Label46: TLabel
      Left = 100
      Top = 92
      Width = 319
      Height = 13
      Caption = '3. for (['#1074#1099#1088#1072#1078#1077#1085#1080#1077'1]; ['#1074#1099#1088#1072#1078#1077#1085#1080#1077'2]; ['#1074#1099#1088#1072#1078#1077#1085#1080#1077'3]) '#1086#1087#1077#1088#1072#1090#1086#1088
    end
    object Label47: TLabel
      Left = 100
      Top = 111
      Width = 319
      Height = 13
      Caption = '4. for '#1086#1087#1077#1088#1072#1090#1086#1088' (['#1074#1099#1088#1072#1078#1077#1085#1080#1077'1]; ['#1074#1099#1088#1072#1078#1077#1085#1080#1077'2]; ['#1074#1099#1088#1072#1078#1077#1085#1080#1077'3])'
    end
    object Label48: TLabel
      Left = 100
      Top = 130
      Width = 157
      Height = 13
      Caption = '5. while ('#1074#1099#1088#1072#1078#1077#1085#1080#1077') '#1086#1087#1077#1088#1072#1090#1086#1088
    end
    object Label49: TLabel
      Left = 100
      Top = 152
      Width = 163
      Height = 13
      Caption = '6. while '#1086#1087#1077#1088#1072#1090#1086#1088' ( '#1074#1099#1088#1072#1078#1077#1085#1080#1077' )'
    end
    object Label41: TLabel
      Left = 168
      Top = 220
      Width = 6
      Height = 13
      Caption = '3'
    end
    object Label53: TLabel
      Left = 107
      Top = 219
      Width = 6
      Height = 13
      Caption = '2'
    end
    object Label54: TLabel
      Left = 31
      Top = 219
      Width = 6
      Height = 13
      Caption = '1'
    end
    object Label68: TLabel
      Left = 16
      Top = 37
      Width = 60
      Height = 13
      Caption = #1054#1087#1077#1088#1072#1090#1086#1088':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label69: TLabel
      Left = 104
      Top = 37
      Width = 62
      Height = 13
      Caption = #1057#1080#1085#1090#1072#1082#1089#1080#1089':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object teQ63: TEdit
      Left = 147
      Top = 192
      Width = 49
      Height = 21
      NumbersOnly = True
      TabOrder = 0
    end
    object teQ62: TEdit
      Left = 83
      Top = 192
      Width = 49
      Height = 21
      NumbersOnly = True
      TabOrder = 1
    end
    object teQ61: TEdit
      Left = 15
      Top = 192
      Width = 49
      Height = 21
      NumbersOnly = True
      TabOrder = 2
    end
    object Button4: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 3
      OnClick = Button4Click
    end
    object Button7: TButton
      Left = 3
      Top = 248
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 4
      OnClick = Button7Click
    end
    object Button8: TButton
      Left = 347
      Top = 248
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 5
      OnClick = Button8Click
    end
  end
  object gbQ7: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'7'
    TabOrder = 10
    Visible = False
    object Label50: TLabel
      Left = 14
      Top = 18
      Width = 349
      Height = 13
      Caption = #1059#1082#1072#1078#1080#1090#1077' '#1074' '#1082#1072#1082#1086#1084' '#1087#1086#1088#1103#1076#1082#1077' '#1074#1099#1074#1077#1076#1091#1090#1100#1089#1103' '#1095#1080#1089#1083#1072' 5 6 7 8 '#1087#1086#1089#1083#1077' '
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label51: TLabel
      Left = 14
      Top = 37
      Width = 191
      Height = 13
      Caption = #1074#1099#1087#1086#1083#1085#1077#1085#1080#1103' '#1089#1083#1077#1076#1091#1102#1097#1077#1075#1086' '#1082#1086#1076#1072': '
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label52: TLabel
      Left = 21
      Top = 64
      Width = 44
      Height = 13
      Caption = 'int k = 0;'
    end
    object Label24: TLabel
      Left = 22
      Top = 83
      Width = 108
      Height = 13
      Caption = 'for (int i = 7; i > 3; i--)'
    end
    object Label55: TLabel
      Left = 46
      Top = 129
      Width = 31
      Height = 13
      AutoSize = False
      Caption = 'k = i+1;'
    end
    object Label56: TLabel
      Left = 24
      Top = 104
      Width = 113
      Height = 19
      AutoSize = False
      Caption = '{'
    end
    object Label63: TLabel
      Left = 46
      Top = 148
      Width = 52
      Height = 13
      Caption = 'cout << k;'
    end
    object Label64: TLabel
      Left = 24
      Top = 164
      Width = 5
      Height = 13
      Caption = '}'
    end
    object Label70: TLabel
      Left = 24
      Top = 215
      Width = 6
      Height = 13
      Caption = '1'
    end
    object Label71: TLabel
      Left = 73
      Top = 215
      Width = 6
      Height = 13
      Caption = '2'
    end
    object Label72: TLabel
      Left = 128
      Top = 215
      Width = 6
      Height = 13
      Caption = '3'
    end
    object Label76: TLabel
      Left = 180
      Top = 215
      Width = 6
      Height = 13
      Caption = '4'
    end
    object teQ71: TEdit
      Left = 21
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 0
    end
    object Button1: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 1
      OnClick = Button1Click
    end
    object Button9: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 2
      OnClick = Button9Click
    end
    object Button10: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 3
      OnClick = Button10Click
    end
    object teQ72: TEdit
      Left = 67
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 4
    end
    object teQ73: TEdit
      Left = 120
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 5
    end
    object teQ74: TEdit
      Left = 170
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 6
    end
  end
  object gbQ8: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'8'
    TabOrder = 11
    Visible = False
    object Label57: TLabel
      Left = 14
      Top = 18
      Width = 339
      Height = 13
      Caption = #1059#1082#1072#1078#1080#1090#1077' '#1074' '#1082#1072#1082#1086#1084' '#1087#1086#1088#1103#1076#1082#1077' '#1074#1099#1074#1077#1076#1091#1090#1100#1089#1103' '#1095#1080#1089#1083#1072' 9 3 6 '#1087#1086#1089#1083#1077' '
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label58: TLabel
      Left = 14
      Top = 37
      Width = 191
      Height = 13
      Caption = #1074#1099#1087#1086#1083#1085#1077#1085#1080#1103' '#1089#1083#1077#1076#1091#1102#1097#1077#1075#1086' '#1082#1086#1076#1072': '
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label59: TLabel
      Left = 22
      Top = 56
      Width = 140
      Height = 13
      Caption = 'int k = 0; bool bTemp = true;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label60: TLabel
      Left = 22
      Top = 76
      Width = 20
      Height = 13
      Caption = 'do {'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label61: TLabel
      Left = 38
      Top = 95
      Width = 58
      Height = 13
      Caption = '++k = k+2;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label62: TLabel
      Left = 38
      Top = 114
      Width = 126
      Height = 13
      Caption = 'if (k == 9) bTemp = false;'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Label19: TLabel
      Left = 40
      Top = 133
      Width = 52
      Height = 13
      Caption = 'cout << k;'
    end
    object Label65: TLabel
      Left = 24
      Top = 160
      Width = 121
      Height = 13
      Caption = '} while (bTemp == true);'
    end
    object Label73: TLabel
      Left = 24
      Top = 215
      Width = 6
      Height = 13
      Caption = '1'
    end
    object Label74: TLabel
      Left = 73
      Top = 215
      Width = 6
      Height = 13
      Caption = '2'
    end
    object Label75: TLabel
      Left = 128
      Top = 215
      Width = 6
      Height = 13
      Caption = '3'
    end
    object teQ81: TEdit
      Left = 22
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 0
    end
    object Button3: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 1
      OnClick = Button3Click
    end
    object Button11: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 2
      OnClick = Button11Click
    end
    object Button12: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 3
      OnClick = Button12Click
    end
    object teQ82: TEdit
      Left = 70
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 4
    end
    object teQ83: TEdit
      Left = 118
      Top = 192
      Width = 25
      Height = 21
      NumbersOnly = True
      TabOrder = 5
    end
  end
  object gbQ9: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'9'
    TabOrder = 12
    Visible = False
    object Label77: TLabel
      Left = 14
      Top = 18
      Width = 150
      Height = 13
      Caption = #1047#1072#1082#1086#1085#1095#1080#1090#1077' '#1087#1088#1077#1076#1083#1086#1078#1077#1085#1080#1077':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label78: TLabel
      Left = 3
      Top = 45
      Width = 391
      Height = 48
      AutoSize = False
      Caption = 
        #1042#1099#1087#1086#1083#1085#1077#1085#1080#1077' '#1086#1087#1077#1088#1072#1090#1086#1088' while '#1087#1088#1086#1076#1086#1083#1078#1072#1077#1090#1089#1103' '#1076#1086' '#1090#1077#1093' '#1087#1086#1088' '#1087#1086#1082#1072' '#1074#1099#1088#1072#1078#1077#1085#1080#1077 +
        ' <'#1086#1090#1074#1077#1090'>'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      WordWrap = True
    end
    object Button14: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 0
      OnClick = Button14Click
    end
    object Button16: TButton
      Left = 347
      Top = 246
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 1
      OnClick = Button16Click
    end
    object Button17: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 2
      OnClick = Button17Click
    end
    object teQ9: TEdit
      Left = 3
      Top = 88
      Width = 121
      Height = 21
      TabOrder = 3
    end
  end
  object gbQ10: TGroupBox
    Left = 0
    Top = 87
    Width = 425
    Height = 274
    Caption = #1042#1086#1087#1088#1086#1089' '#8470'10'
    TabOrder = 13
    Visible = False
    object Label79: TLabel
      Left = 14
      Top = 18
      Width = 374
      Height = 13
      Caption = #1042#1089#1090#1072#1074#1100#1090#1077' '#1074#1077#1088#1085#1086#1077' '#1089#1083#1086#1074#1086' '#1074' '#1087#1088#1077#1083#1086#1078#1077#1085#1080#1077' '#1085#1072' '#1084#1077#1089#1090#1086' '#1089#1083#1086#1074#1072' <'#1086#1090#1074#1077#1090'>:'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label80: TLabel
      Left = 14
      Top = 37
      Width = 339
      Height = 13
      Caption = #1054#1087#1077#1088#1072#1090#1086#1088' <'#1086#1090#1074#1077#1090'> '#1103#1074#1083#1103#1077#1090#1089#1103' '#1086#1087#1077#1088#1072#1090#1086#1088#1086#1084' '#1089' '#1087#1086#1089#1090#1091#1089#1083#1086#1074#1080#1077#1084
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Button13: TButton
      Left = 3
      Top = 246
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 0
      OnClick = Button13Click
    end
    object Button15: TButton
      Left = 162
      Top = 246
      Width = 129
      Height = 25
      Caption = #1055#1086#1076#1090#1074#1077#1088#1076#1080#1090#1100' '#1074#1099#1073#1086#1088
      TabOrder = 1
      OnClick = Button15Click
    end
    object teQ10: TEdit
      Left = 16
      Top = 62
      Width = 121
      Height = 21
      TabOrder = 2
    end
  end
  object pbExit: TButton
    Left = 728
    Top = 336
    Width = 96
    Height = 25
    Caption = #1042#1099#1093#1086#1076
    TabOrder = 14
    OnClick = pbExitClick
  end
end
