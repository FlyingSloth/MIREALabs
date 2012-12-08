//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Grids.hpp>
#include <WebAdapt.hpp>
#include <WebComp.hpp>
#include <DBGrids.hpp>
#include <stdio.h>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TStringGrid *sgMain;
	TEdit *teTarget;
	TStringGrid *sgRes;
	TEdit *teExp;
	TLabel *Label1;
	TLabel *Label2;
	TLabel *Label3;
	TButton *pbConstruct;
	TEdit *teCount;
	TLabel *Label6;
	TButton *pbCalc;
	TButton *pbSave;
	void __fastcall pbConstructClick(TObject *Sender);
	void __fastcall pbCalcClick(TObject *Sender);
	void __fastcall pbSaveClick(TObject *Sender);
private:	// User declarations
	int iTargetN;
	int iExpertsN;
	int iQuestionN;
	bool bTable;
	bool bCalc;

	TDateTime *date;

	void Calculate();
	void SaveToFile();
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
