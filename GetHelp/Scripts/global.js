$(function(){
	
	
	$('#navigation a, #intro .button a').click(function(event){
		event.preventDefault();
		var section = $(this).attr('href').substring(1);
		$('html, body').stop().animate({
			scrollTop: $('#' + section).offset().top-65
		}, 1000);
	});
	
	var counter_date = new Date(new Date().getFullYear(), new Date().getMonth(), new Date().getDate() + 1);
	$('.counter-columns').countdown({
		until: counter_date,
		format: 'HMS'
	});
	
	
	var testimonials_count = 0;
	$('#testimonials .list li').each(function(i){
		if(i != 0) {
			$(this).hide(0);
			testimonials_count++;
		}
	});
	var testimonials_controls = '';
	for(i = 0; i <= testimonials_count; i++) {
		if(i == 0) {
			testimonials_controls += '<span class="active">' + i + '</span>';
		} else {
			testimonials_controls += '<span>' + i + '</span>';
		}
	}
	$('#testimonials .controls').append(testimonials_controls);
	$('#testimonials .controls span').click(function(){
		if($(this).is('.active') === false) {
			var testimonials_control_index = $(this).text();
			$('#testimonials .controls span').removeClass('active');
			$(this).addClass('active');
			$('#testimonials .list li').slideUp(300);
			$('#testimonials .list li:eq(' + testimonials_control_index + ')').slideDown(300);
		}
	});
	
	
	
	});
	
	
