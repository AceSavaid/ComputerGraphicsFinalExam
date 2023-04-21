# ComputerGraphicsFinalExam
 The GitHub Repository for my Intermediate Computer Graphics Final Exam.  
 My ID calculation was 1+3-6 = -4 so my questions are even number related.  
 
 ## Wallpaper
 For the wallpaper I uses a simple diffused normal map that takes in a normal map as well as a material and colour.  
 ![image](https://user-images.githubusercontent.com/69608587/233697440-bdb15c67-355f-41ba-a73b-093a785b18c2.png)
 ![image](https://user-images.githubusercontent.com/69608587/233711039-64ba0f69-63aa-4a3c-aeaf-51dd7a62b4ee.png)


I paired this with a created texture and normal map. to have the rough bumpy wall feeling. 
![image](https://user-images.githubusercontent.com/69608587/233698393-c85c3fbc-2676-46cb-b4f4-10a923eaa84f.png)
![image](https://user-images.githubusercontent.com/69608587/233698444-4cc24fc5-1e3c-420c-9646-463799e912e1.png)



## Lava
Remembering how toon lava was done before, I decided to use a toonramp for my lava effects to have more control on where the brightest and more saturated parts of the shading were. This added movement in the moving lava script would add life to the scene and be able to be toggled with a script but unfortunately I did not have the time to implement. 
![image](https://user-images.githubusercontent.com/69608587/233711111-72ce0a6d-6f14-4c12-8e54-a3ee07e0b800.png)

![image](https://user-images.githubusercontent.com/69608587/233705625-400994b7-54f5-4b1d-ad35-fc5d8240472b.png)


## Bloom
For bloom, it iterates upon the rendered view, making bright parts look more saturated and brighter, in the process bluring the image.  The more iterations there are the brighter the bloom is and the blurrier it is. 
![image](https://user-images.githubusercontent.com/69608587/233710612-b33b224a-af6c-4b01-816f-f30c439e0e8e.png)

Before Bloom 
![image](https://user-images.githubusercontent.com/69608587/233705682-4da61a82-353c-467b-a0ee-dc5187bd8e7d.png)
After Bloom  
![image](https://user-images.githubusercontent.com/69608587/233705707-a51484cf-b630-41e8-a2b5-950037aa1703.png)

To toggle the bloom a script was made. 
![image](https://user-images.githubusercontent.com/69608587/233710537-0e7344cd-1e8d-49cb-b8d3-c909506085d6.png)


## Extra shader
For my extra shader, I used a toonwrap shader with a customized toonwrap I made to have interesting visual effect to the cylinder.  
![image](https://user-images.githubusercontent.com/69608587/233707064-de62c85f-f461-49ef-94cc-8a229f265324.png)

Since I was unsure if this would be enough to count as an extra shader, I added an outline pass to the shader.  This adds a layer behind the object which extrudes the verticies of the object an colours it based on the given Extrusion Amount and Extrusion colour. 
![image](https://user-images.githubusercontent.com/69608587/233707529-42fefe1f-49f6-49cf-a5d2-a785eec4cf93.png)


![image](https://user-images.githubusercontent.com/69608587/233706069-b0862751-80f9-481e-a8f4-4316ba40e41b.png)
