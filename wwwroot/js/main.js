
	//api:  http://www.ist.rit.edu/api/
	$(document).ready(function(){

		$('body').fadeIn(1000);

		//get the about page
		$.ajax({
			type:'get', //always a requests 
			url:'proxy.php',
			data:{path:"/about/"},
			dataType:'json'
		}).done(function(msg){
			//put out the title 
			$('#title').append('<h3>' + msg.title +'</h3>');
			$('#overview').prepend('<h2 style="padding: 20px">Overview: </h2>' + '<p id="box">' + msg.description + '</p>');
			$('#quote').append('<figure><blockquote><p class="quotation">' + msg.quote + '</p></blockquote><figcaption> --' + msg.quoteAuthor + '</figcaption></figure>');
		});

		
		//////////////////////////////////MINORS/////////////////////////////////

			$('#holdMinors').accordion({
					collapsible: true
				})
		});

		

		});
		
		//////////////////////////////////EMPLOYMENT/////////////////////////////////
		xhr('get', {path:'/employment/'}, '#employment').done(function(json){
			//this is for the employment statistics 
			$('#employment').prepend('<h3>'+  json.introduction.title +'</h3>');
			//$('#employment').append('<h4>'+  json.introduction.content[0].title +'</h4>');
			//$('#employment').append('<p>'+  json.introduction.content[0].description +'</p>');
			
			//degree stats
			$('#employmentStats').prepend('<h4>'+  json.degreeStatistics.title +'</h4>');
			$.each(json.degreeStatistics.statistics, function(i, item){
				$('#botOne').append('<p class="bigText">'+  json.degreeStatistics.statistics[i].value +' </p>');
				$('#botTwo').append('<p>' + json.degreeStatistics.statistics[i].description +'</p>');
			});

			//this is for coop information
			
			$('#left').append('<h4>'+  json.introduction.content[0].title +'</h4>');
			$('#left').append('<p>'+  json.introduction.content[0].description +'</p>').css('line-height', '2.3').css('font-weight', '500').css('padding', '23px');
			$('#right').append('<h4>'+  json.introduction.content[1].title +'</h4>');
			$('#right').append('<p>'+  json.introduction.content[1].description +'</p>').css('line-height', '2.3').css('font-weight', '500');
			
			//current employers
			$('#currentEmp').prepend('<h4> Current Employers </h4>');
			$.each(json.employers.employerNames, function(i, item){
				$('#employers').append('<p>'+ json.employers.employerNames[i]  +'</p> <br>');
			});

			//coop table 
			console.log(json.coopTable);
			$.each(json.coopTable.coopInformation, function(i, item){
				$('#coop').append('<tr><td>' + json.coopTable.coopInformation[i].employer + '</td><td>' + 
					json.coopTable.coopInformation[i].city + '</td><td>' + 
						json.coopTable.coopInformation[i].degree + '</td></tr>');
			})

		});


	}); //end of document ready

	

	////////////////////shortcut
	//////////////////ajax util
	/// args 
	////// getPost- is it a get or a post?
	////// d - data 
	////// idForSpinner - id for the tag to put the spinner in 
	//example: xhr('get', {path: '/about/'}, '#contnet').done 
	//// OR: xhr('get', {path: '/about/'}).done

	function xhr(getPost, d, idForSpinner){
		return $.ajax({
			type: getPost,
			data: d,
			url: 'proxy.php',
			cache: false,
			async: true,
			dataType: 'json',
			beforeSend:function(){
				$(idForSpinner).append('<img src = "assets/media/loading.gif" class="bsSpinner"/>');
			}

		}).always(function(){
			//kill spinner
			//$(idForSpinner).find('.bsSpinner').fadeOut(500).remove();
			$(idForSpinner).find('.bsSpinner').fadeOut(500, function(){
				$(this).remove();
			});
		}).fail(function(err){
			console.log(err);
		})
	}


	//use this function to get an exact match on the attribute you are looking for 
	//array: array to look into
	//name: name of the name = value pair to find the obj
	//val: value of the name = value pair to find the obj

	//getAttributesByName(json.faculty, 'username', 'dsbics')
	function getAttributesByName(array, name, val){
		var result = null;
		$.each(array, function(){
			if(this[name]== val){
				result = this;
			}
		});
		return result;
	}

//adds moving particles to the background of top section on load
window.onload = function() {
  Particles.init({
    selector: '.background',
	color: '#00BBFE',
	connectParticles: true
  });
};

$(function(){
    $('table').tablePagination({

    })
})
