from pytube import YouTube
import os
import sys
import json

def Download(url, path):

    try:
        yt = YouTube(url)
        video = yt.streams.filter(only_audio=True).first()
        output = video.download(output_path=path)
        
        base, ext = os.path.splitext(output)
        new = base + '.mp3'
        os.rename(output,new)

        return {
            'title': yt.title,
            'thumbnailUrl': yt.thumbnail_url,
            'videoUrl': url,
            'path': new,
            'failed': False,
            'message': 'You can now play the music ' + yt.title
        }
    except Exception as e:
        return {
            'title': '',
            'thumbnailUrl': '',
            'videoUrl': '',
            'path': '',
            'failed': True,
            'message': str(e)
        }
    
if __name__ == "__main__":
    url = sys.argv[1]
    path = sys.argv[2]
    result = Download(url, path)
    print(json.dumps(result))