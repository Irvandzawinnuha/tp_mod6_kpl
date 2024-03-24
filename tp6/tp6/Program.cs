using tp6;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract - Irvan Dzawin Nuha");
        vid.printVideoDetails();

        SayaTubeVideo vid2 = new SayaTubeVideo("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac massa sit amet nulla iaculis mattis. Phasellus nec mauris eu augue pulvinar fermentum. Mauris at ligula sed nulla lobortis posuere. Nullam volutpat risus vitae diam semper, at vehicula sem faucibus. Nullam non magna ac velit dictum rutrum. Fusce tincidunt velit vitae quam sollicitudin, eget rhoncus justo efficitur. Vivamus fermentum condimentum metus, ac pulvinar magna posuere nec. In hac habitasse platea dictumst. Nulla facilisi. Sed lacinia, dui sed ultricies venenatis, tortor sapien placerat justo, eget mattis tortor libero sed nisi. Maecenas rutrum bibendum dui, at consequat est eleifend id. Sed nec arcu eget lectus bibendum laoreet non in ipsum. Phasellus ac mi sit amet dui condimentum vehicula. Ut tincidunt, quam sit amet rhoncus scelerisque, nisl magna ultricies lectus, sed placerat justo erat eget risus. Sed ac odio felis.\r\n\r\n\r\n\r\n\r\n");
        vid2.increasePlayCount(100000001);
        vid2.printVideoDetails();

        SayaTubeVideo vid3 = new SayaTubeVideo("Apa itu Stack Overflow? - Irvan");
        for (int i = 0; i < 25; i++)
        {
            vid3.increasePlayCount(100000000);
        }

    }
}
