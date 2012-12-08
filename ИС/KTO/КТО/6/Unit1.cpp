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
	lPosFile = 0;
	proffile = fopen("stud.dat","ab+");
	student = new TStudent();
	date = new TDateTime;
	memset(student,0,sizeof(TStudent));
	fseek(proffile,0,SEEK_END);
	lPosFile = ftell(proffile);

	gbQ1->Visible = false;
	gbQ2->Visible = false;
	gbQ3->Visible = false;
	gbQ4->Visible = false;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::btnRegNewClick(TObject *Sender)
{
	gbNew->Visible = true;
	gbEnter->Visible = false;
	pbStart->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnRegClick(TObject *Sender)
{
	gbNew->Visible = false;
	student->login = edtNewPass->Text.ToInt();
	if (edtFIO->Text.Length() < 255)
	{
		sprintf(student->fio,"%s",edtFIO->Text.t_str());
	}
	else
	{
		ShowMessage("Сократите количество символов в ФИО.");// msg сократить фио
	}

	if (edtGroup->Text.Length() < 16)
	{
		sprintf(student->group,"%s",edtGroup->Text.t_str());
	}
	else
	{
		ShowMessage("Сократите количество символов в группе.");// msg сократить фио
	}
	sprintf(&student->date[0],"%s",date->CurrentDate().DateString().t_str());
	fseek(proffile,0,SEEK_END);
	fwrite(student,sizeof(TStudent),1,proffile);
    fflush(proffile);
	lblFIO->Caption = edtFIO->Text;
	lblGroup->Caption = edtGroup->Text;
	lblDate->Caption =  date->CurrentDate().DateString();
	// заполнить лейблы
	pbStart->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnPassEnterClick(TObject *Sender)
{
	bool find = false;
	fseek(proffile,0,SEEK_SET);
	while (!feof(proffile))
	{
		int t = fread(student,sizeof(TStudent),1,proffile);
		if (student->login == edtPassEnter->Text.ToInt())
		{
			find = true;
			lblFIO->Caption   = student->fio;
			lblGroup->Caption = student->group;
			lblDate->Caption  =  student->date;
         	break;
		}
	}

	if(!find)
	ShowMessage("Нет данных.");

	gbEnter->Visible = false;
	pbStart->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::btnEnterClick(TObject *Sender)
{
	gbEnter->Visible = true;
	gbNew->Visible = false;
	pbStart->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbAccept1Click(TObject *Sender)
{
	if (rb11->Checked)
	{
		fprintf(ansFile,"ANS1:1 ");
		pbAccept1->Enabled = false;
	}
	else if (rb12->Checked)
	{
		fprintf(ansFile,"ANS1:2 ");
		pbAccept1->Enabled = false;
	}
	else if (rb13->Checked)
	{
		fprintf(ansFile,"ANS1:3 ");
		pbAccept1->Enabled = false;
	}
	else if (rb14->Checked)
	{
		fprintf(ansFile,"ANS1:4 ");
		pbAccept1->Enabled = false;
	}
	else if (rb15->Checked)
	{
		fprintf(ansFile,"ANS1:5 ");
		pbAccept1->Enabled = false;
	}
	else
		ShowMessage("Выберите ответ");
}
//---------------------------------------------------------------------------


void __fastcall TForm1::pbAccept2Click(TObject *Sender)
{
	if (rb21->Checked)
	{
		fprintf(ansFile,"ANS2:1 ");
		pbAccept2->Enabled = false;
	}
	else if (rb22->Checked)
	{
		fprintf(ansFile,"ANS2:2 ");
			pbAccept2->Enabled = false;
	}
	else if (rb23->Checked)
	{
		fprintf(ansFile,"ANS2:3 ");
			pbAccept2->Enabled = false;
	}
	else if (rb24->Checked)
	{
		fprintf(ansFile,"ANS2:4 ");
			pbAccept2->Enabled = false;
	}
	else if (rb25->Checked)
	{
		fprintf(ansFile,"ANS2:5 ");
			pbAccept2->Enabled = false;
	}
	else
		ShowMessage("Выберите ответ");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbAccept3Click(TObject *Sender)
{
		fprintf(ansFile,"ANS3:");
		pbAccept3->Enabled = false;
		if (chk31->Checked == true)
		{
			fprintf(ansFile,"1");
		}
		else if (chk32->Checked == true)
		{
			fprintf(ansFile,"2");
		}
		else if (chk33->Checked == true)
		{
			fprintf(ansFile,"3");
		}
		else if (chk34->Checked == true)
		{
			fprintf(ansFile,"4");
		}
		else if (chk35->Checked == true)
		{
			fprintf(ansFile,"5");
		}
		else
		{
			ShowMessage("Выберите хотябы один ответ ответ");
				pbAccept3->Enabled = true;
		}

		fprintf(ansFile," ");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbAccept4Click(TObject *Sender)
{
	fprintf(ansFile,"ANS4:");
		pbAccept4->Enabled = false;
		if (chk41->Checked == true)
		{
			fprintf(ansFile,"1");
		}
		else if (chk42->Checked == true)
		{
			fprintf(ansFile,"2");
		}
		else if (chk43->Checked == true)
		{
			fprintf(ansFile,"3");
		}
		else if (chk44->Checked == true)
		{
			fprintf(ansFile,"4");
		}
		else if (chk45->Checked == true)
		{
			fprintf(ansFile,"5");
		}
		else
		{
			ShowMessage("Выберите хотябы один ответ ответ");
				pbAccept4->Enabled = false;
		}

		fprintf(ansFile," ");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::bpNext1Click(TObject *Sender)
{
	gbQ1->Visible = false;
	gbQ2->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbPrev2Click(TObject *Sender)
{
	gbQ1->Visible = true;
	gbQ2->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbNext2Click(TObject *Sender)
{
	gbQ2->Visible = false;
	gbQ3->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbPrev3Click(TObject *Sender)
{
	gbQ2->Visible = true;
	gbQ3->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbNext3Click(TObject *Sender)
{
	gbQ3->Visible = false;
	gbQ4->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbPrev4Click(TObject *Sender)
{
	gbQ3->Visible = true;
	gbQ4->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbNext4Click(TObject *Sender)
{
	gbQ4->Visible = false;
	gbQ5->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbStartClick(TObject *Sender)
{
	if (student->login != 0)
	{
		char *filename = new char[32];
  		gbQ1->Visible = true;
		pbStart->Visible = false;
		sprintf(filename,"answers%i.txt",student->login);
		ansFile = fopen(filename,"w+");
	}
	else
		ShowMessage("Войдите в систему.");

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button5Click(TObject *Sender)
{
	gbQ4->Visible = true;
	gbQ5->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button6Click(TObject *Sender)
{
	gbQ5->Visible = false;
	gbQ6->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button7Click(TObject *Sender)
{
	gbQ5->Visible = true;
	gbQ6->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button8Click(TObject *Sender)
{
	gbQ6->Visible = false;
	gbQ7->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button9Click(TObject *Sender)
{
	gbQ6->Visible = true;
	gbQ7->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button10Click(TObject *Sender)
{
	gbQ7->Visible = false;
	gbQ8->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button11Click(TObject *Sender)
{
    gbQ8->Visible = false;
	gbQ7->Visible = true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button12Click(TObject *Sender)
{
	gbQ8->Visible = false;
	gbQ9->Visible = true;
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Button13Click(TObject *Sender)
{
 	gbQ10->Visible = false;
	gbQ9->Visible = true;

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button14Click(TObject *Sender)
{
	gbQ8->Visible = true;
	gbQ9->Visible = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button16Click(TObject *Sender)
{
	gbQ10->Visible = true;
	gbQ9->Visible = false;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button2Click(TObject *Sender)
{
	fprintf(ansFile,"ANS5:%s %s %s %s ",teQ51->Text.c_str(),teQ52->Text.c_str(),teQ53->Text.c_str(),teQ54->Text.c_str());
	Button2->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
	fprintf(ansFile,"ANS6:%s %s %s ",teQ61->Text.c_str(),teQ62->Text.c_str(),teQ63->Text.c_str());
	Button4->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
	fprintf(ansFile,"ANS7:%s %s %s %s ",teQ71->Text.c_str(),teQ72->Text.c_str(),teQ73->Text.c_str(),teQ74->Text.c_str());
	Button1->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
	fprintf(ansFile,"ANS8:%s %s %s ",teQ81->Text.c_str(),teQ82->Text.c_str(),teQ83->Text.c_str());
	Button3->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button17Click(TObject *Sender)
{
	fprintf(ansFile,"ANS9:%s ",teQ9->Text.c_str());
	Button17->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button15Click(TObject *Sender)
{
	fprintf(ansFile,"ANS10:%s ",teQ10->Text.c_str());
	Button15->Enabled = false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::pbExitClick(TObject *Sender)
{
	Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormClose(TObject *Sender, TCloseAction &Action)
{
	fcloseall();
}
//---------------------------------------------------------------------------

