$('#myCarousel').carousel({
    interval: 3000,
});


[".mask", ".carousel-control-prev", ".carousel-control-next"].forEach(element => {
    $(element).hover(
        function () {
            // $(this).css("background-color", "yellow");
            $('#myCarousel').addClass('show-navi');
        },
        function () {
            // $(this).css("background-color", "pink");
            $('#myCarousel').removeClass('show-navi');
        }
    );
});
