/*
 * Name 	:	Hoverline jQuery Plugin
 * Author 	:	Nakul Ezhuthupally <me@nakule.in>
 * URL 		:	http://nakule.in
 * */

(function($){
		
	$.fn.makeNavbar = function(){
		
		var $this = this;
		
		$this.find('ul').css('list-style','none');
		
		$this.find('ul li').css({
			'float'		:	'left',
			'margin'	:	'0px 10px'
		});
		
		$this.find('ul li a').css({
			'text-decoration'	:	'none',
			'padding'			:	'3px 5px'
		});
		
		$this.append('<div style="clear:both;"></div>')
		
		return $this;
		
	}
	
	$.fn.hoverline = function(options){
					
	    var settings = $.extend({
		  'color'       		:		'#333',
		  'height'				:		'2px',
		  'start'				:		'1',
		  'speed'				:		'200',
		  'border'				:		'none',
		  'borderwidthside'		:		'1px',
		  'borderwidthtop'		:		'1px',
		  'borderstyle'			:		'solid'
		}, options);
		
		var $hoverline = $('<div>');
		
		$hoverline.attr('class','hoverline');
		$hoverline.css({
			'background'	:	settings.color,
			'height'		:	settings.height,
			'border-color'	:	settings.border,
			'border-style'	:	settings.borderstyle,
			'border-width'	:	settings.borderwidthtop + ' ' + settings.borderwidthside,
			'width'			:	'1px',
			'position'		:	'absolute',
			'left'			:	'1px',
			'bottom'		:   '3em', 
		});
		
		if(settings.border == "none")
			$hoverline.css('border','0');
		
		this.each(function(){
			
			$this = $(this);

			function moveHover(){
				$link = $(this);
				$(this).parent().parent().parent().find('.hoverline').stop().animate({
					'left'	:	$link.position().left,
					'width'	:	$link.parent().width()
				}, speed);
			}
			
			function clickedItem(){
				$(this).parent().parent().parent().find('ul li a.currElement').removeClass('currElement');
				$(this).addClass('currElement');
			}
			
			function leaveHover(){
				$link = $(this).find('ul li a.currElement');
				$(this).find('.hoverline').stop().animate({
					'left'	:	$link.position().left,
					'width'	:	$link.parent().width()
				}, speed);
			}
		
			$this.css('position','relative');
			
			$this.append('<div style="clear:both;"></div>');
			
			$this.append($hoverline.clone());
			
			$hoverline = $this.find('.hoverline');
					
			var speed = parseInt(settings.speed);
					
			$this.find('ul li a').bind('click',clickedItem);
			
			$this.find('ul li a').bind('mouseenter',moveHover);
			
			$this.bind('mouseleave',leaveHover);
			
			$this.find('ul li a').eq(settings.start-1).addClass('currElement');
			
			$this.trigger('mouseleave');
		
		});
		
		return this;

	};
})( jQuery );
