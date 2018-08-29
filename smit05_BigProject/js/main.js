$(document).ready(function() {
    CheckBox();
    //

    $(".mobele-nav .toggle").click(function() {
        $(".menu").slideToggle();
        $(".menu ul").css("display", "none");
    });

    $(".menu li").click(function() {
        //$(".menu ul").slideUp();
        $(this).find('ul').slideToggle();
    });

    $(window).resize(function() {
        if ($(window).width() > 768) {
            $(".menu ul").removeAttr('style');
        }
    });
});

function CheckBox() {
    $('label input[type="radio"]:checked, label input[type="checkbox"]:checked').parents('label').addClass('checked');
    $(document).on('click', 'label input[type="radio"]', function(e) {
        var radioName = $(this).attr('name');
        if (radioName) {
            $('label input[name=' + radioName + ']').parents('label').removeClass('checked');
            $('label input[name=' + radioName + ']:checked').parents('label').addClass('checked');
        }
    });
    $(document).on('click', 'label input[type="checkbox"]', function(e) {
        $(this).parents('label').toggleClass('checked');
    });
}
