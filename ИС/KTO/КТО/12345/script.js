var question, ansver;
function radio(question, ansver)
{
	if(question == '1')
	{
		if(ansver == '1')
		{
			$('.repeat_link_1').html("Это правильный ответ.");
		}
		else if(ansver == '2')
		{
			$('.repeat_link_1').html("Не правильно.<br /><a href='index.html'>Повторить материал</a>");
		}
		else 
		{
			$('.repeat_link_1').html("Не правильно.<br /><a href='index.html'>Повторить материал</a>");		
		}
	}
	if(question == '2')
	{
		if(ansver == '2')
		{
			$('.repeat_link_2').html("Это правильный ответ");
		}
		else // ansver = 1 или 3
		{
			$('.repeat_link_2').html("<a href='do.html'>Повторить материал</a>");
		}	
	}
	if(question == '3')
	{
		if(ansver == '3')
		{
			$('.repeat_link_3').html("Это правильный ответ");
		}
		else
		{
			$('.repeat_link_3').html("<a href='for.html'>Повторить материал</a>");
		}	
	}
	if(question == '4')
	{
		if(ansver == '3')
		{
			$('.repeat_link_4').html("Это правильный ответ");
		}
		else 
		{
			$('.repeat_link_4').html("<a href='for.html'>Повторить материал</a>");
		}	
	}	
}