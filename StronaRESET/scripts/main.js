$(window).on('resize', function () {
    $('.pull-down').each(function () {
        $(this).hide();
        $(this).css('margin-top', $(this).parent().height() - $(this).height());
        $(this).show();
    });
}).resize();