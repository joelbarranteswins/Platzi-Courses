
## Proyecto del curso de Inteligencia Artificial: ChatGPT, DALL-E y Hugging Face

### `Joel Barrantes`

</br></br>

## Using AI to generate Images

### Creating images with DALL-E
 * Prompt: Abres los ojos y te encuentras flotando en el espacio, rodeado por una infinidad de estrellas. A medida que te acostumbras a la oscuridad, te das cuenta de que algo enorme se está acercando hacia ti desde la lejanía. Pronto te das cuenta de que es una gigantesca ballena cósmica, nadando sin esfuerzo por el vacío del espacio. Su cuerpo brillante emite una luz propia, y cuando pasa junto a ti, puedes sentir su respiración cálida y húmeda.

    <div align="center">
    <img src="./Dall-E/generate-1.png">
    </div>

* prompt: character design, void arcanist, mist, photorealistic, octane render, unreal engine, hyper detailed, volumetric lighting.

    <div align="center">
    <img src="./Dall-E/generate-2.png">
    </div>


* prompt: 3D render, k9, Police dog, logo, multicam, anime character with magic, superpowers, wearing flight goggles and many details.

    <div align="center">
    <img src="./Dall-E/generate-3.png">
    </div>


### Usando Midjourney

* prompt: character design, void arcanist, mist, photorealistic, octane render, unreal engine, hyper detailed, volumetric lighting.

    <div align="center">
    <img src="./Midjourney/generate-1.png">
    </div>


## 2. Usando Notebook

* I use this image to test some models
<div align="center">
<img src="./imgs/photo-two-kittens.png">
</div>

### Object Detection

~~~python
from PIL import Image
from transformers import pipeline
import numpy as np
import cv2
import matplotlib.pyplot as plt

image = Image.open("./imgs/photo-two-kittens.png")

object_detector = pipeline('object-detection', model='facebook/detr-resnet-50')
detections_coodinates = object_detector(image)


image = np.array(image)

# Dibujar un rectángulo alrededor de cada objeto detectado
for obj in detections_coodinates:
    xmin, ymin, xmax, ymax = obj['box'].values()
    cv2.rectangle(image, (xmin, ymin), (xmax, ymax), (0, 255, 0), thickness=2)
    label = obj['label']
    cv2.putText(image, label, (xmin, ymin - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 255), 1)

# Mostrar la imagen resultante en una notebook de Jupyter
plt.figure(figsize=(12, 12))
plt.title('Object detection by joel barrantes')
plt.imshow(cv2.cvtColor(image, cv2.COLOR_BGR2RGB))
plt.axis('off')
plt.show()
~~~

  <div align="center">
  <img src="./imgs/object-detection.png">
  </div>

### Image classification

~~~python
from transformers import pipeline

classifier = pipeline(task="image-classification")
preds = classifier(
    "./imgs/photo-two-kittens.png"
)
preds = [{"score": round(pred["score"], 4), "label": pred["label"]} for pred in preds]
print(*preds, sep="\n")
~~~

  <div align="center">
  <img src="./imgs/image-classification.png">
  </div>

### Image to Text

~~~python
from transformers import VisionEncoderDecoderModel, ViTImageProcessor, AutoTokenizer
import torch
from PIL import Image

model = VisionEncoderDecoderModel.from_pretrained("nlpconnect/vit-gpt2-image-captioning")
feature_extractor = ViTImageProcessor.from_pretrained("nlpconnect/vit-gpt2-image-captioning")
tokenizer = AutoTokenizer.from_pretrained("nlpconnect/vit-gpt2-image-captioning")

device = torch.device("cuda" if torch.cuda.is_available() else "cpu")
model.to(device)



max_length = 16
num_beams = 4
gen_kwargs = {"max_length": max_length, "num_beams": num_beams}
def predict_step(image_paths):
  images = []
  for image_path in image_paths:
    i_image = Image.open(image_path)
    if i_image.mode != "RGB":
      i_image = i_image.convert(mode="RGB")

    images.append(i_image)

  pixel_values = feature_extractor(images=images, return_tensors="pt").pixel_values
  pixel_values = pixel_values.to(device)

  output_ids = model.generate(pixel_values, **gen_kwargs)

  preds = tokenizer.batch_decode(output_ids, skip_special_tokens=True)
  preds = [pred.strip() for pred in preds]
  return preds

image = Image.open("./Dall-E/space-man-studying.png")
image = np.array(image)
plt.figure(figsize=(8, 8))
plt.imshow(cv2.cvtColor(image, cv2.COLOR_BGR2RGB))
plt.axis('off')
plt.show()

predict_step(['./Dall-E/space-man-studying.png'])
~~~

  <div align="center">
  <img src="./imgs/Image-to-text.png">
  </div>

### Automatic Speech Recognition

~~~python
from huggingsound import SpeechRecognitionModel

model = SpeechRecognitionModel("jonatasgrosman/wav2vec2-large-xlsr-53-english")
audio_paths = ["./audio/mlk.flac"]

transcriptions = model.transcribe(audio_paths)
print(transcriptions)
~~~

  <div align="center">
  <img src="./imgs/automatic-speech-recognition.png">
  </div>


## conclusions:
1. There are a plethora of open source models available for download, installation, and testing. This allows for experimentation with various models to determine the best fit for the project at hand.
2. The generation of images with tools like DALL-E 2, Midjourney, and Stable Difusion can be achieved. However, it is important to provide clear and accurate descriptions to ensure the AI generates the desired output. Among these tools, I found Stable Difusion to be particularly effective, as it allows for on-demand generation of high-quality images.
3. The Transformer library proved to be an excellent choice for my project due to its ease of use and versatility. With a solid understanding of the desired outcome, this library can help to create an interesting and engaging project.


## Recommendation::
1. It's important to understand that machine learning models are not easy to comprehend right away. It takes time and effort to learn the basics and recognize the applications of supervised learning, unsupervised learning, reinforcement learning, and deep learning. Therefore, it is recommended that you take the time to learn the basics before diving into more complex models. This will help you build a solid foundation of knowledge, making it easier to understand and apply advanced machine learning concepts in the future.















