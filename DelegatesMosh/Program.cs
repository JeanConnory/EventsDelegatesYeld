using DelegatesMosh;

var video = new Video()
{
    Title = "Video 1"
};

var videoEncoder = new VideoEncoder(); //Publisher
var mailService = new MailService(); //Subscriber
var messageService = new MessageService(); //Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //Subscreve esse método no evento VideoEncoded
videoEncoder.VideoEncoded += messageService.OnVideoEncoded; 

videoEncoder.Encode(video);
