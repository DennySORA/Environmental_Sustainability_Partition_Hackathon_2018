from django.shortcuts import render
from django.http import HttpResponse
import time
import socket
# Create your views here.


HOST = '192.168.1.136'
PORT = 5472
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((HOST, PORT))


def index(request):
    return render(request, 'index.html')


def about_me(request):
    return render(request, 'html/about_me.html')


def Test(request):
    return render(request, 'html/Test.html',)


def intorduc(request):
    return render(request, 'html/intorduc.html')


def idea(request):
    return render(request, 'html/idea.html')


def asktime(request):
    data = s.recv(1024)
    return HttpResponse(data)
