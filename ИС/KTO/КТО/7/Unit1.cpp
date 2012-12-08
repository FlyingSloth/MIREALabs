//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	iTargetN = 0;
	iExpertsN = 0;
	iQuestionN = 0;
	bTable = false;
	bCalc = false;
	date = new TDateTime;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::pbConstructClick(TObject *Sender)
{
	if (teTarget->Text.IsEmpty() || teExp->Text.IsEmpty() || teCount->Text.IsEmpty())
	{
		ShowMessage("Введите все параметры таблицы");
		return;
	}

	sgMain->DestroyComponents();
	sgRes->DestroyComponents();

	iTargetN = teTarget->Text.ToInt();
	iExpertsN = teExp->Text.ToInt();
	iQuestionN = teCount->Text.ToInt();

	int iCount = 0;
	int iRows  = iQuestionN;
	iCount = iTargetN*iExpertsN;

	sgMain->FixedRows = 2;
	sgMain->RowCount = iRows+2;
	sgMain->ColCount = iCount+1;
	sgRes->RowCount = iRows+1;
	sgRes->ColCount = teTarget->Text.ToInt()+1;
	for (int i = 0; i < iRows; i++)
	{
		sgMain->Cells[0][i+2] = UnicodeString("Задание ") + UnicodeString(i+1);
		sgRes->Cells[0][i+1] = UnicodeString("Задание ") + UnicodeString(i+1);
	}


	int exp = 0;
	int targ = 0;
	for (int i = 1; i < iCount+1; i++)
	{
		if ((exp%iExpertsN) == 0)
		{
			exp = 0;
			sgMain->Cells[i][0] = UnicodeString("Цель ") + UnicodeString(targ+1);
			targ++;
		}
		sgMain->Cells[i][1] = UnicodeString("Эксперт ") + UnicodeString(exp+1);
		exp++;

		sgRes->Cells[i][0] = UnicodeString("Цель ") + UnicodeString(i);


	}
	bTable = true;
}
//---------------------------------------------------------------------------
void  TForm1::Calculate()
{
	float fResult = 0.;
	float fMidAll = 0.;
	float fMidOne = 0.;
	if (bTable)
	{
		for (int i = 2; i < iQuestionN+2; i++)
		{
        	fMidAll = 0.;
			for (int l = 1; l < iExpertsN*iTargetN+1; l++)
				fMidAll += sgMain->Cells[l][i].ToDouble();

			fMidAll /= (float)iExpertsN*iTargetN;

			for (int k = 0; k < iTargetN; k++)
			{
				fMidOne = 0.;
				fResult = 0.;
				for (int g = k*iExpertsN; g < (k*iExpertsN+iExpertsN); g++)
				{
					fMidOne += sgMain->Cells[g+1][i].ToDouble();
				}
				fMidOne /= iExpertsN;
				fResult = (iTargetN/((2.*iTargetN)-2.))*(fMidOne - fMidAll);   // main formul need to be tested
				sgRes->Cells[k+1][i-1] = UnicodeString(fResult);
			}
		}
		bCalc = true;
	}

}

void  TForm1::SaveToFile()
{
	if (bCalc)
	{
		  FILE *pf = fopen("RESULTS.txt","a+");
		  fprintf(pf,"РАССЧЁТ %s\n",date->CurrentDateTime().TimeString().t_str());
		  for (int i = 2; i < iQuestionN+2; i++)
		  {
			fprintf(pf,"Задание %i\n",i-1);
			 for (int k = 0; k < iTargetN; k++)
			 {
				fprintf(pf,"Цель %i: %.2f \n",k+1,sgRes->Cells[k+1][i-1].ToDouble());
			 }
		  }
		  fprintf(pf,"\n");
		  fclose(pf);
	}
}

void __fastcall TForm1::pbCalcClick(TObject *Sender)
{
try
{
	Calculate();
}
catch (EConvertError&)
{
	ShowMessage("Ошибка. Проверьте корректность заполнения таблицы!");
}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbSaveClick(TObject *Sender)
{
	SaveToFile();
}
//---------------------------------------------------------------------------

