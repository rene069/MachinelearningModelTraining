
# Pokemon Detector Using Machine Learning

## Task

The goal of this project is to create a website that can determine if an uploaded picture corresponds to any of the 151 Pokémon from Generation 1. If the initial model is uncertain about the result, the user will have the opportunity to provide input to improve the accuracy of the classification.

## Dataset

The dataset used for this project consists of images of Pokémon from Generation 1. Additional dataset for Pokémon statistics has been compiled, excluding data from Generations 2 to 9.

[DataSet For Gen 1 Images](https://www.kaggle.com/datasets/echometerhhwl/pokemon-gen-1-38914)


## Possible Version 2

A potential enhancement for the future is to expand the model to include Pokémon from later generations (Gen 2 and onwards) to create a more comprehensive Pokémon detection system.

## ChangeLog

 **Dataset Version 3.2.1:**

-   Identified and removed more duplicate images from the dataset.
-   Addressed specific issues with distinguishing between "Pidgeot" and "Pidgeotto" from certain angles.
-   Achieved a slightly lower accuracy of 75% due to the dataset modifications.

**File Changes:**

-   Fixed problems with git and model file paths.

**Dataset Version 3.2:**

-   Combined the 100 and 50 images to create a new model.
-   Achieved an accuracy of around 76% with the combined dataset.

**Dataset Version 3.1.1:**

-   Added additional images and removed some.
-   Improved accuracy to around 73%.

**Dataset Version 3.1:**

-   Added 50 more pictures of each Pokemon.
-   Model accuracy decreased to around 67%.
-   Plan to experiment with different pictures to improve accuracy.

**Dataset Version 3:**

-   Training Sets with 100 pictures per Pokemon.
-   Model performance improved, but still uncertain on some Pokemon.
-   Enhanced the model's ability to distinguish between certain Pokemon, like "Pidgeot" and "Pidgeotto."

**Dataset Version 2:**

-   Removed around 800 irrelevant or mislabeled pictures from the dataset.
-   Addressed the issue of unrelated and duplicate photos.
-   Dataset refined for quality.

**Dataset Version 1:**

-   Dataset: 35,000 pictures
-   Initial model accuracy: 79%
-   Identified problems with distinguishing between certain Pokemon.
-   Observed overfitting for some Pokemon and underfitting for others.
