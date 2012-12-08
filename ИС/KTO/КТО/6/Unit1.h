//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <stdio.h>

//---------------------------------------------------------------------------

struct TStudent
{
	long login;
	char fio[128];
	char group[16];
	char date[16];
	TStudent() {memset(this,0,sizeof(TStudent));};
	~TStudent() {};
};

//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TGroupBox *GroupBox1;
	TLabel *Label1;
	TLabel *Label2;
	TLabel *Label3;
	TLabel *lblFIO;
	TLabel *lblGroup;
	TLabel *lblDate;
	TButton *btnEnter;
	TButton *btnRegNew;
	TGroupBox *gbNew;
	TLabel *Label4;
	TLabel *Label5;
	TEdit *edtFIO;
	TEdit *edtGroup;
	TButton *btnReg;
	TEdit *edtNewPass;
	TLabel *Label6;
	TGroupBox *gbEnter;
	TLabel *Label7;
	TEdit *edtPassEnter;
	TButton *btnPassEnter;
	TGroupBox *gbQ1;
	TButton *pbStart;
	TGroupBox *gbQ2;
	TLabel *Label8;
	TLabel *Label9;
	TLabel *Label10;
	TLabel *Label11;
	TLabel *Label12;
	TLabel *Label13;
	TLabel *Label14;
	TRadioButton *rb11;
	TRadioButton *rb12;
	TRadioButton *rb13;
	TRadioButton *rb14;
	TRadioButton *rb15;
	TButton *pbAccept1;
	TLabel *Label20;
	TLabel *Label21;
	TRadioButton *rb21;
	TRadioButton *rb22;
	TRadioButton *rb23;
	TRadioButton *rb24;
	TRadioButton *rb25;
	TButton *pbAccept2;
	TGroupBox *gbQ3;
	TLabel *Label15;
	TLabel *Label16;
	TButton *pbAccept3;
	TCheckBox *chk31;
	TCheckBox *chk32;
	TCheckBox *chk33;
	TCheckBox *chk34;
	TCheckBox *chk35;
	TGroupBox *gbQ4;
	TLabel *Label17;
	TLabel *Label18;
	TCheckBox *chk41;
	TCheckBox *chk42;
	TCheckBox *chk43;
	TCheckBox *chk44;
	TCheckBox *chk45;
	TButton *pbAccept4;
	TButton *bpNext1;
	TButton *pbNext2;
	TButton *pbPrev2;
	TButton *pbPrev3;
	TButton *pbNext3;
	TButton *pbPrev4;
	TButton *pbNext4;
	TGroupBox *gbQ5;
	TLabel *Label22;
	TLabel *Label25;
	TLabel *Label23;
	TLabel *Label26;
	TLabel *Label27;
	TEdit *teQ51;
	TEdit *teQ52;
	TEdit *teQ53;
	TEdit *teQ54;
	TLabel *Label28;
	TLabel *Label29;
	TLabel *Label30;
	TLabel *Label31;
	TLabel *Label32;
	TLabel *Label33;
	TLabel *Label34;
	TLabel *Label35;
	TLabel *Label36;
	TLabel *Label37;
	TLabel *Label38;
	TGroupBox *gbQ6;
	TLabel *Label40;
	TLabel *Label39;
	TLabel *Label42;
	TLabel *Label43;
	TLabel *Label44;
	TLabel *Label45;
	TLabel *Label46;
	TLabel *Label47;
	TLabel *Label48;
	TLabel *Label49;
	TGroupBox *gbQ7;
	TLabel *Label50;
	TLabel *Label51;
	TLabel *Label52;
	TEdit *teQ71;
	TEdit *teQ63;
	TLabel *Label41;
	TLabel *Label53;
	TEdit *teQ62;
	TEdit *teQ61;
	TLabel *Label54;
	TLabel *Label24;
	TLabel *Label55;
	TLabel *Label56;
	TGroupBox *gbQ8;
	TLabel *Label57;
	TLabel *Label58;
	TEdit *teQ81;
	TLabel *Label59;
	TLabel *Label60;
	TLabel *Label61;
	TLabel *Label62;
	TLabel *Label63;
	TLabel *Label64;
	TLabel *Label19;
	TLabel *Label65;
	TButton *Button1;
	TButton *Button2;
	TButton *Button3;
	TButton *Button4;
	TButton *Button5;
	TButton *Button6;
	TButton *Button7;
	TButton *Button8;
	TButton *Button9;
	TButton *Button10;
	TButton *Button11;
	TButton *Button12;
	TLabel *Label66;
	TLabel *Label67;
	TLabel *Label68;
	TLabel *Label69;
	TEdit *teQ82;
	TEdit *teQ83;
	TEdit *teQ72;
	TEdit *teQ73;
	TLabel *Label70;
	TLabel *Label71;
	TLabel *Label72;
	TLabel *Label73;
	TLabel *Label74;
	TLabel *Label75;
	TEdit *teQ74;
	TLabel *Label76;
	TGroupBox *gbQ9;
	TLabel *Label77;
	TLabel *Label78;
	TGroupBox *gbQ10;
	TLabel *Label79;
	TLabel *Label80;
	TButton *Button13;
	TButton *Button15;
	TButton *Button14;
	TButton *Button16;
	TButton *Button17;
	TEdit *teQ9;
	TEdit *teQ10;
	TButton *pbExit;
	void __fastcall btnRegNewClick(TObject *Sender);
	void __fastcall btnRegClick(TObject *Sender);
	void __fastcall btnPassEnterClick(TObject *Sender);
	void __fastcall btnEnterClick(TObject *Sender);
	void __fastcall pbAccept1Click(TObject *Sender);
	void __fastcall pbAccept2Click(TObject *Sender);
	void __fastcall pbAccept3Click(TObject *Sender);
	void __fastcall pbAccept4Click(TObject *Sender);
	void __fastcall bpNext1Click(TObject *Sender);
	void __fastcall pbPrev2Click(TObject *Sender);
	void __fastcall pbNext2Click(TObject *Sender);
	void __fastcall pbPrev3Click(TObject *Sender);
	void __fastcall pbNext3Click(TObject *Sender);
	void __fastcall pbPrev4Click(TObject *Sender);
	void __fastcall pbNext4Click(TObject *Sender);
	void __fastcall pbStartClick(TObject *Sender);
	void __fastcall Button5Click(TObject *Sender);
	void __fastcall Button6Click(TObject *Sender);
	void __fastcall Button7Click(TObject *Sender);
	void __fastcall Button8Click(TObject *Sender);
	void __fastcall Button9Click(TObject *Sender);
	void __fastcall Button10Click(TObject *Sender);
	void __fastcall Button11Click(TObject *Sender);
	void __fastcall Button12Click(TObject *Sender);
	void __fastcall Button13Click(TObject *Sender);
	void __fastcall Button14Click(TObject *Sender);
	void __fastcall Button16Click(TObject *Sender);
	void __fastcall Button2Click(TObject *Sender);
	void __fastcall Button4Click(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Button3Click(TObject *Sender);
	void __fastcall Button17Click(TObject *Sender);
	void __fastcall Button15Click(TObject *Sender);
	void __fastcall pbExitClick(TObject *Sender);
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
private:	// User declarations
	FILE *ansFile;
	FILE *proffile;
	long lPosFile;

	TStudent *student;
    TDateTime *date;



public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
