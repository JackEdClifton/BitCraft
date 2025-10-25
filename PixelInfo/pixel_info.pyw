import pyautogui
from pyautogui import position, pixel
import pygame

pygame.init()
window = pygame.display.set_mode((220,175))
pygame.display.set_caption("Mouse Position") 

font = pygame.font.SysFont("Courier New", 20, 1)


def denary():
    return str(pyautogui.pixel(*pyautogui.position()))

def hexadecimal():
    rgb = pyautogui.pixel(*pyautogui.position())
    r = hex(rgb[0])[2:]
    g = hex(rgb[1])[2:]
    b = hex(rgb[2])[2:]
    if len(r) == 1: r = f"0{r}"
    if len(g) == 1: g = f"0{g}"
    if len(b) == 1: b = f"0{b}"
    return str("".join([r,g,b])).upper()


run = True
while run:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False

    try:
        mouse_x, mouse_y = position()
        window.fill((0,0,50))
        window.blit(font.render("x: "+str(mouse_x), True, (255,255,255)), (5,10))
        window.blit(font.render("y: "+str(mouse_y), True, (255,255,255)), (5,50))
        window.blit(font.render("c: "+denary(), True, (255,255,255)), (5,90))
        window.blit(font.render("h: "+hexadecimal(), True, (255,255,255)), (5,130))
        pygame.display.update()
    except Exception as E:
        print("An issue occured", E)
        input()



pygame.quit()
